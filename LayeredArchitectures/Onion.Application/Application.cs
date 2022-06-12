using MapsterMapper;
using Onion.Abstractions;
using Onion.Abstractions.Dto;
using Onion.Domain;

namespace Onion.Application
{
    public class Application : IApplication
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public Application(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public OrderDto PlaceOrder(OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);

            var result = _orderRepository.Save(order);

            return _mapper.Map<OrderDto>(result);
        }

        public OrderDto GetOrder(Guid id)
        {
            var order = _orderRepository.GetById(id);

            return _mapper.Map<OrderDto>(order);
        }
    }
}