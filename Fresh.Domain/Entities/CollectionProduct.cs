namespace Fresh.Domain.Entities
{

    public class CollectionProduct
    {
        public int CollectionProductId { get; set; }

        public int CollectionId { get; set; }
        public SeasonalCollection? SeasonalCollection { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}