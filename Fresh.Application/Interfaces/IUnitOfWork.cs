using Fresh.Domain.Entities;

namespace Fresh.Application.Interfaces;

public interface IUnitOfWork
{
    IRepository<Brand> Brands { get; }
    IRepository<Category> Categories { get; }
    IRepository<Product> Products { get; }
    IRepository<ColorProduct> ColorProduct { get; }
    IRepository<SizeOption> Sizes { get; }
    IRepository<ProductImage> ProductImages { get; }
    IRepository<ProductSize> ProductSizes { get; }
    IRepository<User> Users { get; }
    IRepository<Order> Orders { get; }
    IRepository<OrderItem> OrderItems { get; }
    IRepository<Payment> Payments { get; }
    IRepository<SeasonalCollection> SeasonalCollections { get; }
    IRepository<CollectionProduct> CollectionProducts { get; }

    Task Save();
}