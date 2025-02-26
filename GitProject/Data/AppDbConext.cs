using GitProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GitProject.Data
{
    public class AppDbConext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AppDbConext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }


    }
}
