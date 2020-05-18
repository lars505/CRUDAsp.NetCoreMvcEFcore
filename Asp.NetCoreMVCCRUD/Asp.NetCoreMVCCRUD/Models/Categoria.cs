using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Asp.NetCoreMVCCRUD.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="CAmpo Requerido")]
        [StringLength(50, MinimumLength = 3,ErrorMessage ="El nombre debe de tener 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage = "El campo no debe de exceder los 256 caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required]
        public Boolean Estado { get; set; }
    }
}
