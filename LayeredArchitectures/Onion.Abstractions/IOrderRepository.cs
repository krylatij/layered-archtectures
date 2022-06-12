using Onion.Domain;

namespace Onion.Abstractions;

public interface IOrderRepository
{
    Order GetById(Guid id);
    Order Save(Order order);
}