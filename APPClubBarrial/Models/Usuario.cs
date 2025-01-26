using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace APPClubBarrial.Models
{
    public class Usuario : IdentityUser
    {

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El nombre completo no puede tener mas de 30 caracteres.")]
        public string Names { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El apellido completo no puede tener mas de 30 caracteres.")]
        public string LastNames { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [RegularExpression(@"^\d{7,8}$")]
        public string DNI {  get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [RegularExpression(@"^\+(?:[0-9] ?){6,14}[0-9]$")]
        public string Telephone { get; set; }
      
    }
}
