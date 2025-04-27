using ClasePractica24_4_2025.Models;
using Microsoft.EntityFrameworkCore;


namespace ClasePractica24_4_2025.Data
{
    public class ConsultorioContext : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = JOSEGFONSECA; DataBase = ConsultorioDB; Trusted_Connection = true; Encrypt = false; TrustServerCertificate = true;");
        }
    }
}
