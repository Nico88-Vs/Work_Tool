using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Tool_LibreriaClassi;

namespace Work_Tool.WorkToll_libreria_di_classi
{
    public enum Status
    {
        archiviato,
        sospeso,
        inattesa,
        inprogettazione,
        attivo,
        completato,
    }
    public class Progetto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Label_ Label { get; set; } = new Label_();
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public List<Task_> Tasks { get; set; } = new List<Task_>();
        [Required]
        public DateTime StarData { get; set; }
        public DateTime EstimatedEnd { get; set; }
        public TimeSpan RollingTime { get; set; }
        public double Progress { get; set; }
        public Status Status { get; set; }
    }
}
