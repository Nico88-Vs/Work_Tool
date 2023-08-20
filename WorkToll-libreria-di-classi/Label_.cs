using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace W_Tool_LibreriaClassi
{
    public class Label_
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ambit { get; set; } = "Study";
        [Required]
        public string LabelColor { get; set; } = Color.White.Name;

        public override string ToString()
        {
            return Ambit;
        }

    }
}
