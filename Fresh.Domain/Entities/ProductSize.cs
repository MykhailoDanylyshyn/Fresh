namespace Fresh.Domain.Entities
{
    public class ProductSize
    {
        public int ProductSizeId { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int SizeId { get; set; }
        public SizeOption? SizeOption { get; set; }

        public int StockQuantity { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
