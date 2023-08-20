using System.Diagnostics.CodeAnalysis;
using System.IO;
using Work_Tool.WorkToll_libreria_di_classi;

namespace Work_Tool.Utility
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Project_Manager
    {
        public List<Task_> Task_list { get; set; }
        private Progetto Progetto { get; set; }
        public string ResourcePath { get; set; }

        //  todo : evidenzate possibili vulnerabilita
        public Project_Manager(List<Task_> task_list, Progetto progetto, string PrjectPath)
        {
            this.Task_list = task_list;
            this.Progetto = progetto;

            this.Progetto.Tasks = task_list;

            this.ResourcePath = CreateSubFolder(PrjectPath); 
        }

        public Project_Manager(Progetto progetto, string PrjectPath)
        {
            this.Task_list = progetto.Tasks;
            this.Progetto = progetto;

            ResourcePath = CreateSubFolder(PrjectPath);
        }

        public static Progetto BuildPrj(List<Task_> tasks, string name, Label_ label, string description , int daysPertask = 2, Status status = Status.inattesa)
        {

            //TODO: Aggiungere Notifiche e funzioni di verifica sul pusch del progetto

            Progetto output = new Progetto()
            {
                Tasks = tasks,
                Name = name,
                Description = description,
                Label = label,
                Status = status,
                StarData = DateTime.UtcNow,
                EstimatedEnd = DateTime.UtcNow.AddDays(tasks.Count * daysPertask),
                Progress = 0
            };
            return output;
        }

        public static void UpdatePrj(Progetto p)
        {
            p.Progress = CalculateProgres(p);
            p.RollingTime = p.StarData - DateTime.UtcNow;
        }

        [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
        public static double CalculateProgres(Progetto progetto)
        {
            double prog = 0;

            var totalTask = progetto.Tasks.Count;
            var complitedtasks = progetto.Tasks.Where(x => x.StattusTask == StattusTask.completed).ToList().Count;
            prog = complitedtasks / totalTask;

            return prog;
        }

        private string CreateSubFolder(string parentFolderPath)
        {
            var subFolderName = $"{Progetto.Name}";

            // Verifica se la cartella principale esiste
            if (!Directory.Exists(parentFolderPath))
            {
                Directory.CreateDirectory(parentFolderPath);
            }

            // Crea il percorso completo per la sottocartella
            var subFolderPath = Path.Combine(parentFolderPath, subFolderName);

            // Verifica se la sottocartella esiste
            if (!Directory.Exists(subFolderPath))
            {
                Directory.CreateDirectory(subFolderPath);
            }

            return subFolderPath;
        }

    }
}
