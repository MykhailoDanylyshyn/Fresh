using Fresh.Domain.Enums;

namespace Fresh.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public required string OrderNumber { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = [];
        public ICollection<Payment> Payments { get; set; } = [];
    }
}
