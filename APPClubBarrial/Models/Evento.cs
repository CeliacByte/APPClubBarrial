using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPClubBarrial.Models
{
    public class Evento
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio.")]
        [MaxLength(100,ErrorMessage = "El nombre no puede tener mas de 100 caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "La sede es obligatorio.")]
        [ForeignKey("Sede")]
        public Sede Sede { get; set; }
        [Required(ErrorMessage = "La actividad es obligatorio.")]
        [ForeignKey("Actividad")]
        public Actividad Actividad{ get; set; }
        public DateTime FechaHora { get; set; }
        [Required(ErrorMessage = "Debe ingresar una duracion")]
        public TimeSpan Duracion { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatoria.")]
        [MaxLength(300, ErrorMessage = "La descripcion no puede tener mas de 300 caracteres.")]
        public string Descripcion { get; set; }
        [ForeignKey("Usuario")]
        public Usuario Usuario { get; set; } //Usuario creador del evento
    }
}
