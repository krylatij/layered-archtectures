using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Onion.Abstractions;

namespace Onion.Infrastructure
{
    public static class Register
    {
        public static void AddInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IOrderRepository, OrderRepository>();
        }
    }
}
