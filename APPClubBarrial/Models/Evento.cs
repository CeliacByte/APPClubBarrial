using System.ComponentModel.DataAnnotations;

namespace APPClubBarrial.Models
{
    public class Evento
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio.")]
        [MaxLength(100,ErrorMessage = "El nombre no puede tener mas de 100 caracteres.")]
        public string Name { get; set; }   

        public Actividad Actividad { get; set; }
        public DateTime FechaHora { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioId { get; set; }
    }
}
