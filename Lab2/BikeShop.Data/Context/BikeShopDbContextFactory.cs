using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BikeShop.Data.Context;

public class BikeShopDbContextFactory : IDesignTimeDbContextFactory<BikeShopDbContext>
{
    public BikeShopDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<BikeShopDbContext>();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServcerConnectionString"));

        return new BikeShopDbContext(optionsBuilder.Options);
    }
}