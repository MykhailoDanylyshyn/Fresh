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

            // Забезпечуємо унікальність коду товару
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.ProductCode)
                .IsUnique();

            // Встановлюємо точність ціни товару
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            // Забороняємо повторення однакових розмірів для одного товару
            modelBuilder.Entity<ProductSize>()
                .HasIndex(ps => new { ps.ProductId, ps.SizeId })
                .IsUnique();

            // Забороняємо дублювання товарів в одній колекції
            modelBuilder.Entity<CollectionProduct>()
                .HasIndex(cp => new { cp.CollectionId, cp.ProductId })
                .IsUnique();

            // Забезпечуємо унікальність логіна користувача
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique();

            // Забезпечуємо унікальність електронної пошти
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Забезпечуємо унікальність номера замовлення
            modelBuilder.Entity<Order>()
                .HasIndex(o => o.OrderNumber)
                .IsUnique();

            // Встановлюємо точність загальної суми замовлення
            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasPrecision(18, 2);

            // Встановлюємо точність ціни товару в замовленні
            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.UnitPrice)
                .HasPrecision(18, 2);

            // Встановлюємо точність суми платежу
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(18, 2);

            // Встановлюємо точність відсотка знижки
            modelBuilder.Entity<SeasonalCollection>()
                .Property(c => c.DiscountPercent)
                .HasPrecision(5, 2);

            // Обмежуємо розмір знижки від 0 до 100 відсотків
            modelBuilder.Entity<SeasonalCollection>()
                .ToTable(t => t.HasCheckConstraint(
                    "CK_SeasonalCollection_DiscountPercent",
                    "[DiscountPercent] >= 0 AND [DiscountPercent] <= 100"));

            // Встановлюємо заборону на ціну з -
            modelBuilder.Entity<Product>()
               .ToTable(t => t.HasCheckConstraint(
                    "CK_Product_Price",
                     "[Price] >= 0"));

            // Забороняємо від'ємну кількість товару на складі
            modelBuilder.Entity<ProductSize>()
                .ToTable(t => t.HasCheckConstraint(
                    "CK_ProductSize_StockQuantity",
                    "[StockQuantity] >= 0"));

            // Забороняємо нульову та від'ємну кількість товару в замовленні
            modelBuilder.Entity<OrderItem>()
                .ToTable(t => t.HasCheckConstraint(
                    "CK_OrderItem_Quantity",
                    "[Quantity] > 0"));
        }

    }
}
