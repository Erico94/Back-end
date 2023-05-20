using API_Pessoal.Models;
using Microsoft.EntityFrameworkCore;
namespace API_Pessoal.Context
{
    public class SemanasContext : DbContext
    {
        public DbSet<SemanaModel> Semanas { get; set; }

        public SemanasContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
