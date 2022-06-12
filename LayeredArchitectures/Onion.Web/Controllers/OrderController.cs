using Microsoft.AspNetCore.Mvc;
using Onion.Abstractions;
using Onion.Abstractions.Dto;

namespace Onion.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IApplication _application;

        private readonly ILogger<OrderController> _logger;

        public OrderController(IApplication application, ILogger<OrderController> logger)
        {
            _application = application;
            _logger = logger;
        }
        
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var order = _application.GetOrder(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] OrderDto orderDto)
        {
            var order = _application.PlaceOrder(orderDto);
            
            return Ok(order);
        }
    }
}