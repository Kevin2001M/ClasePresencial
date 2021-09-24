using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Models
{
    public class Usuario
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Error Este campo es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Error Este campo es requerido")]

        public int Edad { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Error Este campo es requerido")]

        public char Sexo { get; set; }

        [Display(Name = "Estudio")]
        [Required(ErrorMessage = "Error Este campo es requerido")]

        public string Estudio { get; set; }
    }
}
