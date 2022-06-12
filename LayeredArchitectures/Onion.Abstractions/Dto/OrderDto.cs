using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Abstractions.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }

        public OrderItemDto[] Items { get; set; }

        public DateTimeOffset CreationDate { get; set; }
    }
}
