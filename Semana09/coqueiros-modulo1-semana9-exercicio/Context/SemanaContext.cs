using Microsoft.EntityFrameworkCore;
using coqueiros_modulo1_semana9_exercicio.Controllers;
using coqueiros_modulo1_semana9_exercicio.Model;

namespace coqueiros_modulo1_semana9_exercicio.Context
{
    public class SemanaContext : DbContext
    {
        public SemanaContext() { }
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<SemanaModel> Semanas { get; set; }
    }
}
