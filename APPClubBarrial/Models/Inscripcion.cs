using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPClubBarrial.Models
{
    public class Inscripcion
    {
        public int id {  get; set; }
        [ForeignKey("Usuario")]
        public string UsuarioId { get; set; }
        [Required(ErrorMessage = "Debe ingresar un usuario.")]
        public Usuario Usuario { get; set; } //Usuario que se inscribe 
        [ForeignKey("Sede")]
        public int SedeId { get; set; }
        [Required(ErrorMessage ="Debe ingresar una sede.")]
        public Sede Sede { get; set; }
        [ForeignKey("Actividad")]
        public int ActividadId { get; set; }
        [Required(ErrorMessage = "Debe ingresar una actividad")]
        public Actividad Actividad { get; set; }
        public DateTime Fecha { get; set; } //Fecha al momento de la inscripcion
        public EstadoInscripcion Estado { get; set; }
    }
}
