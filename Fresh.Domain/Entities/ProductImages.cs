namespace Fresh.Domain.Entities
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public required string ProductImageURL { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
