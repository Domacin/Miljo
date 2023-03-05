using Microsoft.EntityFrameworkCore;

namespace Dostava.Models
{
    public class PoruciDbContext : DbContext
    {
        public PoruciDbContext(DbContextOptions<PoruciDbContext> options)
          : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
