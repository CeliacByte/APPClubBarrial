using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using APPClubBarrial.Models;

namespace APPClubBarrial.Data
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options ) : base( options ) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de la jerarquía de Actividad
            modelBuilder.Entity<Actividad>()
                .HasDiscriminator<string>("TipoActividad")
                .HasValue<Deportiva>("Deportiva")
                .HasValue<NoDeportiva>("NoDeportiva");

            // Restricción para horarios
            modelBuilder.Entity<Horario>()
            .ToTable(tb =>
                tb.HasCheckConstraint("CK_Horario_Horas", "HoraInicio < HoraFin"));

        }
    }
}
