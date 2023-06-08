using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebApplication.DataAccess.Context
{
    public class WebApplicationContext : DbContext
    {
        private readonly string _connectionString;
        public WebApplicationContext(string connectionString) { _connectionString = connectionString; }
        public WebApplicationContext(DbContextOptions<WebApplicationContext> option) : base(option) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrWhiteSpace(_connectionString))
                optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
