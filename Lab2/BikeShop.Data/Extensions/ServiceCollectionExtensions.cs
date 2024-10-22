using BikeShop.Data.Context;
using BikeShop.Data.Repositories;
using BikeShop.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BikeShop.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<BikeShopDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServcerConnectionString"), opt =>
                {
                    opt.MigrationsAssembly(Assembly.GetAssembly(typeof(BikeShopDbContext))?.FullName);
                });
                options.EnableSensitiveDataLogging();
            });

            serviceCollection.AddScoped<IBikeRepository, BikeRepository>();
            serviceCollection.AddScoped<IBikeTypeRepository, BikeTypeRepository>();
            serviceCollection.AddScoped<IFeedbackRepository, FeedbackRepository>();

            return serviceCollection;
        }
    }
}
