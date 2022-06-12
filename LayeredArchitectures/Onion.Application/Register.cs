

using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using Onion.Abstractions;
using Onion.Abstractions.Dto;
using Onion.Domain;

namespace Onion.Application
{
    public static class Register
    {
        public static void AddApplication(this IServiceCollection services)
        { 
            services.AddTransient<IApplication, Application>();

            var config = TypeAdapterConfig.GlobalSettings;
            config.NewConfig<Order, OrderDto>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.CreationDate, src => src.CreatedAt)
                .Map(dest => dest.Items, src => src.Items);

            config.NewConfig<OrderDto, Order>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.CreatedAt, src => src.CreationDate)
                .Map(dest => dest.Items, src => src.Items);

            config.NewConfig<OrderItemDto, OrderItem>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Price, src => src.Sum)
                .Map(dest => dest.Quantity, src => src.Count);

            config.NewConfig<OrderItem, OrderItemDto>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Sum, src => src.Price)
                .Map(dest => dest.Count, src => src.Quantity);

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();
        }
    }
}
