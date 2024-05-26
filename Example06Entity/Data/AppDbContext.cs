using Example06Entity.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example06Entity.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Otel> Otels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-6LKAQV9R;Initial Catalog=OtelDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Otel>().Property(o => o.Name).HasMaxLength(25);
            modelBuilder.Entity<Otel>().Property(o => o.Description).HasMaxLength(100);
            modelBuilder.Entity<Otel>().Property(o => o.Phone).HasMaxLength(11);
        }
    }
}
