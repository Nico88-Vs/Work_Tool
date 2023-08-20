using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Tool_LibreriaClassi
{
    public class Riferimenti
    {
        [Key]
        public int Id { get; set; }
        public string Titolo { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;
    }
}
