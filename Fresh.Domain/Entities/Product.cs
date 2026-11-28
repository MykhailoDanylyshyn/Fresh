namespace Fresh.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string ProductCode { get; set; }
        public string? Description { get; set; }

        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        public int ColorId { get; set; }
        public ColorProduct? Color { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; } = [];
        public ICollection<ProductSize> ProductSizes { get; set; } = [];
        public ICollection<CollectionProduct> CollectionProducts { get; set; } = [];
    }
}
