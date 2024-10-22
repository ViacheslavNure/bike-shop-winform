using BikeShop.Application.Services;
using BikeShop.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BikeShop.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IBikeService, BikeService>();

            return serviceCollection;
        }
    }
}
