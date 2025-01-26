using System.ComponentModel.DataAnnotations;

namespace APPClubBarrial.Models
{
    public class Sede
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es necesario.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "La direccion es necesaria.")]
        public string direccion { get; set; }

        public List<Evento> Events { get; set; }
        public List<Actividad> Actividades { get; set; }

        public Sede()
        {
            Events = new List<Evento>();
            Actividades = new List<Actividad>();
        }

    }


}
