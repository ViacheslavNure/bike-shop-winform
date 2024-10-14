using Lab2.DbConnection.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

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