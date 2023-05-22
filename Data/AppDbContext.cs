using api_aspnet.Models;
using Microsoft.EntityFrameworkCore;

namespace api_aspnet.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "DataSource = AppDbContext.db; Cache=Shared");
        }
    }
}