using Microsoft.EntityFrameworkCore;
using TheSurvivors.Domain.Models;

namespace TheSurvivors.Domain.Context
{
    public class TheSurvivorsContext : DbContext
    {
        private string ConnectionString { get; }

        public DbSet<Job> Jobs { get; set; }

        public TheSurvivorsContext()
        {
            ConnectionString = "Server=.\\SQLEXPRESS;Database=TheSurvivorsDatabase;Trusted_Connection=True;";
        }

        public TheSurvivorsContext(IConnectionStringProvider connectionStringProvider)
        {
            ConnectionString = connectionStringProvider.ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}