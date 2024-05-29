using Example07ActionResult.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace Example07ActionResult.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
      
        public DbSet<Country> Countries { get; set; }
        public DbSet<Example07ActionResult.Data.Entites.Hotel> Hotel { get; set; } = default!;
    }
}
