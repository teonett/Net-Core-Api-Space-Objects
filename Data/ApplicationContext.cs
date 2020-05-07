using Microsoft.EntityFrameworkCore;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=spaceObjects.db");
            }
        }

        public DbSet<Planet> Planet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comet>().HasKey(x => x.Id);
            modelBuilder.Entity<Constelation>().HasKey(x => x.Id);
            modelBuilder.Entity<Exoplanet>().HasKey(x => x.Id);
            modelBuilder.Entity<Galaxy>().HasKey(x => x.Id);
            modelBuilder.Entity<Moon>().HasKey(x => x.Id);
            modelBuilder.Entity<Planet>().HasKey(x => x.Id);
            modelBuilder.Entity<Star>().HasKey(x => x.Id);
        }
    }
}
