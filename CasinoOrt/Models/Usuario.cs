using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoOrt.Models
{
    public class Usuario
    {
        //ejemplos de validacionesl
        //[Range(18, 60, ErrorMessage = "Error, tiene que ser mayor de edad")]


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage ="Ingrese el nombre de usuario")]
        [Display(Name ="Nombre de Usuario")]
        [StringLength(10)]
        public string nombreUsuario { get; set; }
        [Required(ErrorMessage = "Ingrese la contraseña")]
        public string contraseña { get; set; }

        [Required(ErrorMessage = "Ingrese su nombre")]
        [StringLength(10)]
        public string nombre { get; set; }
        [Required]
        public int monto { get; set; }
    }
}
