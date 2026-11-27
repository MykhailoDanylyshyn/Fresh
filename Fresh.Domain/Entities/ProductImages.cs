namespace Fresh.Domain.Entities
{
    public class ProductImage
    {
        public int ImageId { get; set; }
        public required string ImageURL { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
