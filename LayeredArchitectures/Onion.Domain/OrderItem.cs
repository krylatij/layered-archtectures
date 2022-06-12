using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain
{
    public class OrderItem
    {
        public Guid Id { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
