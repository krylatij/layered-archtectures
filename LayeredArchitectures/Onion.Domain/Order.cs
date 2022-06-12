namespace Onion.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public OrderItem[] Items { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}