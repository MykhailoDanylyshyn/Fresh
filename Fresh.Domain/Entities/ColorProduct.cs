namespace Fresh.Domain.Entities
{
    public class ColorProduct
    {
        public int ColorProductId { get; set; }
        public required string ColorName { get; set; }

        public ICollection<Product> Products { get; set; } = [];
    }
}
