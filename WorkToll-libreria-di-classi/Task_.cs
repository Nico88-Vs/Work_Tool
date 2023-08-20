using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Tool_LibreriaClassi;

namespace Work_Tool.WorkToll_libreria_di_classi
{
    public enum StattusTask
    {
        completed,
        waiting,
        running,
        aborted,
        preparing
    }
    public class Task_
    {
        [Key]
        public int Id { get; set; } // DB ID
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Nome { get; set; } = string.Empty;
        public int? ParentID { get; set; }
        [Required]
        public StattusTask StattusTask { get; set; } = StattusTask.preparing;
        [Required]
        public Progetto Progetto { get; set; } = new Progetto();
        [Required]
        public List<Riferimenti> Riferiemnti { get; set; } = new List<Riferimenti>();
        [Required]
        public string Suggerimenti { get; set; } = string.Empty;
        [Required]
        public string Esercizi { get; set; } = string.Empty;
        [Required]
        public double relazioneIterna { get; set; } = 0;
                      
        public Task_() 
        {
        }
    }
}
