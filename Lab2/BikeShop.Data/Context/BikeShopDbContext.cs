using BikeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BikeShop.Data.Context
{
    public class BikeShopDbContext : DbContext
    {
        public DbSet<Bike> Bike { get; set; }

        public DbSet<BikeType> BikeType { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public BikeShopDbContext(DbContextOptions<BikeShopDbContext> options) : base(options)
        {
        }
    }
}
