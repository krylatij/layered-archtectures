using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Abstractions.Dto;

public class OrderItemDto
{
    public Guid Id { get; set; }

    public int Count { get; set; }

    public decimal Sum { get; set; }
}

