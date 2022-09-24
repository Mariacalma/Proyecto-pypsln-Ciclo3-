using Microsoft.EntityFrameworkCore;
using pypSln.App.dominio;
namespace pypSln.App.persistencia
{
    public class appContext : DbContext
    {
        public DbSet<propietario> propietarios { get; set; }
        public DbSet<veterinario> veterinarios { get; set; }
        public DbSet<ovino> ovinos { get; set; }
        public DbSet<visitapyp> visitapyps { get; set; }
        public DbSet<registroHistoria> registroHistorias { get; set; }
        public DbSet<historiaClinica> historiaClinicas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured)// configuracion de la base de datos
            {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=jornadapyp_v3");
            }
        }
    }
}