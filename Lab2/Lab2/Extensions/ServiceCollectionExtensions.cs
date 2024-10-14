using Lab2.DbConnection.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Lab2.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbConnection(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<BikeShopDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlServcerConnectionString")));

            return serviceCollection;
        }
    }
}
