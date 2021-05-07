using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "titulo es obligatorio")]
        [StringLength(50, ErrorMessage = "el {0} debe ser de al menos 2 y maximo {1} caracteres")]
        [Display(Name ="Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]
        public DateTime FechaLanzamiento { get; set;}
        [Required(ErrorMessage = "descripcion es obligatoria")]
        [StringLength(50, ErrorMessage = "el {0} debe ser de al menos 2 y maximo {1} caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "autor es obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "precio es obligatorio")]

        public int Precio { get; set; }

    }

}
