namespace APPClubBarrial.Models
{
    public class Sede
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
