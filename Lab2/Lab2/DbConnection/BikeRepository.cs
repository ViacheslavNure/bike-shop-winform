using Lab2.DbConnection.DbContext;
using Lab2.DbConnection.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab2.DbConnection
{
    public class BikeRepository
    {

        private readonly BikeShopDbContext context;

        public BikeRepository(BikeShopDbContext context)
        {
            this.context = context;
        }

        public Bike AddBike(Bike bike)
        {
            var existingBikeType = context.BikeType.FirstOrDefault(x => x.Name == bike.BikeType.Name);

            if (existingBikeType is null)
            {
                context.Add(bike.BikeType);
            }
            else
            {
                bike.BikeTypeId = existingBikeType.Id;

                existingBikeType.Description = bike.BikeType.Description;
                context.Update(existingBikeType);
            }

            var createdBike = context.Add(bike);
            context.SaveChanges();

            return createdBike.Entity;
        }

        public List<Bike> GetBikeList()
        {
            return context.Bike.AsNoTracking().ToList();
        }

        public Bike GetBikeById(Guid id)
        {
            return context.Bike
                .AsNoTracking()
                .Include(x => x.BikeType)
                .Include(x => x.Feedbacks)
                .FirstOrDefault(x => x.Id == id) ?? throw new ArgumentNullException($"There is no bikes with id: {id}");
        }
    }
}
