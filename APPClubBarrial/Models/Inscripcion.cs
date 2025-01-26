using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPClubBarrial.Models
{
    public class Inscripcion
    {
        public int id {  get; set; }
        [ForeignKey("Usuario")]
        public Usuario Usuario { get; set; } //Usuario que se inscribe 
        [Required(ErrorMessage ="Debe ingresar una sede.")]
        [ForeignKey("Sede")]
        public Sede Sede { get; set; }
        [Required(ErrorMessage = "Debe ingresar una actividad")]
        [ForeignKey("Actividad")]
        public Actividad Actividad { get; set; }
        public DateTime Fecha { get; set; } //Fecha al momento de la inscripcion
        public EstadoInscripcion Estado { get; set; }
    }
}
