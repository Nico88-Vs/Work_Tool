using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Tool_LibreriaClassi
{
    public class Idea
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]

        public Label_ Label { get; set; } = new Label_();
        public Idea(string description)
        {
            Description = description;
        }
        public Idea()
        {
            
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
