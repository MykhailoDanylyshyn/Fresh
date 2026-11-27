namespace Fresh.Domain.Entities
{
    public class SizeOption
    {
        public int SizeId { get; set; }
        public required string SizeName { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<ProductSize> ProductSizes { get; set; } = [];
    }
}
