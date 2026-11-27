namespace Fresh.Domain.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        public required string BrandName { get; set; }
        public ICollection<Product> Products { get; set; } = [];
    }
}
