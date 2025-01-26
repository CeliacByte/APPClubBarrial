using System.ComponentModel.DataAnnotations;

namespace APPClubBarrial.Models
{
    public abstract class Actividad
    {
        public int id {  get; set; }
        [Required(ErrorMessage = "El nombre es necesario.")]
        [MaxLength(50,ErrorMessage ="El nombre no puede tener mas de 50 caracteres.")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "La descripcion es necesaria.")]
        [MaxLength(300, ErrorMessage = "La descripcion no puede tener mas de 300 caracteres.")]
        public string descripcion { get; set; }


    }
}
