using Microsoft.Extensions.Logging;
using Onion.Abstractions;
using Onion.Domain;

namespace Onion.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ILogger<OrderRepository> _logger;

        public OrderRepository(ILogger<OrderRepository> logger)
        {
            _logger = logger;
        }

        public Order GetById(Guid id)
        {
            _logger.LogInformation($"getting order by id {id}.");

            return new Order
            {
                Id = id,
                CreatedAt = DateTimeOffset.MinValue
            };
        }

        public Order Save(Order order)
        {
            _logger.LogInformation("saving order.");

            order.Id = Guid.NewGuid();
            order.CreatedAt = DateTimeOffset.Now;
            
            return order;
        }
    }
}