using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Tool_LibreriaClassi
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public ToDoItem(string task)
        {
            Task = task;
            IsCompleted = false;
        }

        public ToDoItem()
        {
            
        }

        public override string ToString()
        {
            return IsCompleted ? "[✓] " + Task : "[ ] " + Task;
        }
    }
}
