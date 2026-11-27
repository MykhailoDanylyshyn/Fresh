namespace Fresh.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } = [];
        public ICollection<SizeOption> SizeOptions { get; set; } = [];
    }
}
