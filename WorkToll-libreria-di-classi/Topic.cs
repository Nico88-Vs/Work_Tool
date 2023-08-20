using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Tool_LibreriaClassi
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; } = "";
        [Required]
        [MaxLength(100)]
        public string Description { get; set; } = "";
        [Required]
        public Label_ Label { get; set; } = new Label_();
        public int? ParentId { get; set; }
        public List<Topic>? SubTopic { get; set; }

        public Topic()
        {
        }

        public override string ToString()
        {
            return Subject;
        }
    }
}
