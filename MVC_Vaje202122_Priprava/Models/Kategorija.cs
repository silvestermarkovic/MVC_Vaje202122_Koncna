using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Vaje202122_Priprava.Models
{
    public class Kategorija
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string naziv { get; set; }

       
        [Display (Name ="Vrstni red")]
        [Range(1,100,ErrorMessage ="Vrstni red mora imeti vrednost med 1 in 100!!")]
        public int vrstniRed { get; set; }


        public DateTime ustvarjeno { get; set; } = DateTime.Now;

        public string opis { get; set; }

        public string url { get; set; }

    }
}
