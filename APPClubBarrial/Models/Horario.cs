using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPClubBarrial.Models
{
    public enum DiaSemana
    {
        Lunes,
        Martes,
        Miércoles,
        Jueves,
        Viernes,
        Sábado,
        Domingo
    }
    public class Horario
    {
        public int id { get; set; }
        [Required]
        [ForeignKey("Actividad")]
        public Actividad Actividad { get; set; }
        [Required]
        [ForeignKey("Sede")]
        public Sede Sede { get; set; }
        [Required(ErrorMessage = "Debe tener un dia de la semana asignado.")]
        public DiaSemana Dia { get; set; }
        [Required(ErrorMessage ="Debe tener una Hora de inicio.")]
        public TimeSpan HoraInicio { get; set; }
        [Required(ErrorMessage = "Debe tener una Hora de finalizacion.")]
        public TimeSpan HoraFin {  get; set; }


    }
}
