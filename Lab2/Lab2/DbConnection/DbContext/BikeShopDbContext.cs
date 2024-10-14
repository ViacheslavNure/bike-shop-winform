using Lab2.DbConnection.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab2.DbConnection.DbContext
{
    public class BikeShopDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Bike> Bike { get; set; }

        public DbSet<BikeType> BikeType { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public BikeShopDbContext(DbContextOptions<BikeShopDbContext> options) : base(options)
        {
        }
    }
}
