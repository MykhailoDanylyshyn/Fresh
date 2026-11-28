
using Fresh.Domain.Entities;
using Fresh.Infrastructure.EF;
using Fresh.Application.Interfaces;

namespace Fresh.Infrastructure.Repositories;

public class EFUnitOfWork(FreshContext db) : IUnitOfWork
{
    private IRepository<Brand>? _brands;
    private IRepository<Category>? _categories;
    private IRepository<Product>? _products;
    private IRepository<ColorProduct>? _colorProduct;
    private IRepository<SizeOption>? _sizes;
    private IRepository<ProductImage>? _productImages;
    private IRepository<ProductSize>? _productSizes;
    private IRepository<User>? _users;
    private IRepository<Order>? _orders;
    private IRepository<OrderItem>? _orderItems;
    private IRepository<Payment>? _payments;
    private IRepository<SeasonalCollection>? _seasonalCollections;
    private IRepository<CollectionProduct>? _collectionProducts;

    public IRepository<Brand> Brands =>
        _brands ??= new Repository<Brand>(db);

    public IRepository<Category> Categories =>
        _categories ??= new Repository<Category>(db);

    public IRepository<Product> Products =>
        _products ??= new Repository<Product>(db);

    public IRepository<ColorProduct> ColorProduct =>
        _colorProduct ??= new Repository<ColorProduct>(db);

    public IRepository<SizeOption> Sizes =>
        _sizes ??= new Repository<SizeOption>(db);

    public IRepository<ProductImage> ProductImages =>
        _productImages ??= new Repository<ProductImage>(db);

    public IRepository<ProductSize> ProductSizes =>
        _productSizes ??= new Repository<ProductSize>(db);

    public IRepository<User> Users =>
        _users ??= new Repository<User>(db);

    public IRepository<Order> Orders =>
        _orders ??= new Repository<Order>(db);

    public IRepository<OrderItem> OrderItems =>
        _orderItems ??= new Repository<OrderItem>(db);

    public IRepository<Payment> Payments =>
        _payments ??= new Repository<Payment>(db);

    public IRepository<SeasonalCollection> SeasonalCollections =>
        _seasonalCollections ??= new Repository<SeasonalCollection>(db);

    public IRepository<CollectionProduct> CollectionProducts =>
        _collectionProducts ??= new Repository<CollectionProduct>(db);

    public async Task Save()
    {
        await db.SaveChangesAsync();
    }
}








