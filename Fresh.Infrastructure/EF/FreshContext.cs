using Microsoft.EntityFrameworkCore;
using Fresh.Domain.Entities;


namespace Fresh.Infrastructure.EF
{
    public class FreshContext : DbContext
    {
        public FreshContext(DbContextOptions<FreshContext> options)
                   : base(options)
        {
        }

        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Color> Colors => Set<Color>();
        public DbSet<SizeOption> SizeOptions => Set<SizeOption>();
        public DbSet<ProductImage> ProductImages => Set<ProductImage>();
        public DbSet<ProductSize> ProductSizes => Set<ProductSize>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<SeasonalCollection> SeasonalCollections => Set<SeasonalCollection>();
        public DbSet<CollectionProduct> CollectionProducts => Set<CollectionProduct>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

    
        }
    }
}
