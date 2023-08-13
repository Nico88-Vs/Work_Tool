using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Task_ : Idea
    {
        public StattusTask StattusTask { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public DateTime StartingData { get; set; }
        public DateTime EndData { get; set; }
        [Required]
        public Progetto Progetto { get; set; } = new Progetto();

        public Task_(string description) : base(description)
        {
        }
    }
}
