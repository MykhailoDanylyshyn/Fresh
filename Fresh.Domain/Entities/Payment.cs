using Fresh.Domain.Enums;

namespace Fresh.Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public decimal Amount { get; set; }

        public string? TransactionId { get; set; }
        public DateTime? PaidAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
