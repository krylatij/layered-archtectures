using Onion.Abstractions.Dto;

namespace Onion.Abstractions;

public interface IApplication
{
    OrderDto PlaceOrder(OrderDto order);
    OrderDto GetOrder(Guid id);
}