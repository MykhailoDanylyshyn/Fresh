using Fresh.Domain.Enums;

namespace Fresh.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public UserRole Role { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public string? Password { get; set; }
        public string? Salt { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        public required string Country { get; set; }
        public required string City { get; set; }
        public required string Street { get; set; }
        public required string Building { get; set; }
        public string? Apartment { get; set; }
        public required string PostalCode { get; set; }

        public ICollection<Order> Orders { get; set; } = [];
    }
}
