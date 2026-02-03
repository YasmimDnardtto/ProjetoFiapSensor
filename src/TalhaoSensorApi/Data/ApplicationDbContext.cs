using Microsoft.EntityFrameworkCore;
using TalhaoSensorApi.Models;

namespace TalhaoSensorApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<RegistroSensor> RegistroSensores { get; set; } = null!;
        public DbSet<TalhaoHistoricoStatus> TalhaoHistoricoStatuses { get; set; } = null!;
        public DbSet<Talhao> Talhaos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Nenhuma configuração especial necessária por agora; modelos usam chaves por convenção (Id ou <TypeName>Id)
        }
    }
}