using Lab02.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Master>().HasIndex(m => m.Phone).IsUnique();
        }

    }
}
