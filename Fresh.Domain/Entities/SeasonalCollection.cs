namespace Fresh.Domain.Entities;

public class SeasonalCollection
{
    public int SeasonalCollectionId { get; set; }
    public required string CollectionName { get; set; }
    public string? Description { get; set; }
    public string? VideoURL { get; set; }

    public decimal DiscountPercent { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }

    public ICollection<CollectionProduct> CollectionProducts { get; set; } = [];
}