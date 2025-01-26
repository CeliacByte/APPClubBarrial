namespace APPClubBarrial.Models
{
    public class Deportiva : Actividad
    {
        public List<Horario> horarios { get; set; }
        public Deportiva()
        {
            horarios = new List<Horario>();
        }
    }
}
    
