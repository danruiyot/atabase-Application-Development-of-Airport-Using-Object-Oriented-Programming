using Microsoft.EntityFrameworkCore;

namespace Sporting2021_power.Data
{
    public class SportingPowerContext : DbContext
    {
        //         public DbSet<Technician> Technician { get; set; }
        // public DbSet<Customer> Customer { get; set; }
        // public DbSet<Product> Product { get; set; }
        // public DbSet<Incident> Incident { get; set; }

        public SportingPowerContext (
            DbContextOptions<SportingPowerContext> options)
            : base(options)
        {
        }

        public DbSet<Sporting2021_power.Models.Product> Product { get; set; }
        public DbSet<Sporting2021_power.Models.Customer> Customer { get; set; }
        public DbSet<Sporting2021_power.Models.Technician> Technician { get; set; }
        public DbSet<Sporting2021_power.Models.Incident> Incident { get; set; }
        public DbSet<Sporting2021_power.Models.Registration> Registration { get; set; }
        public DbSet<Sporting2021_power.Models.Country> Country { get; set; }
    }
}