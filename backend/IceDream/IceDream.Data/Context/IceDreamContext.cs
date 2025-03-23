using IceDream.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IceDream.Data.Context
{
    public class IceDreamContext : DbContext
    {
        public IceDreamContext(DbContextOptions<IceDreamContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
