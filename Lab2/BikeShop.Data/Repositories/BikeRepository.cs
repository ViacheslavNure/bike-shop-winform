using BikeShop.Data.Context;
using BikeShop.Data.Entities;
using BikeShop.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BikeShop.Data.Repositories
{
    public class BikeRepository : IBikeRepository
    {

        private readonly BikeShopDbContext context;

        public BikeRepository(BikeShopDbContext context)
        {
            this.context = context;
        }

        public void AddBike(Bike bike)
        {
            var bikeTypeId = context.BikeType
                .AsNoTracking()
                .FirstOrDefault(x => x.Name == bike.BikeType.Name)?.Id;

            if (!bikeTypeId.HasValue)
            {
                throw new ArgumentNullException(nameof(bikeTypeId), $"Bike type with name {bike.BikeType.Name} was not found.");
            }

            bike.BikeTypeId = bikeTypeId.Value;
            bike.BikeType = null!;

            var createdBike = context.Bike.Add(bike);
            context.SaveChanges();
        }

        public List<Bike> GetBikeList()
        {
            return context.Bike
                .AsNoTracking()
                .ToList();
        }

        public Bike GetBikeById(Guid id)
        {
            return context.Bike
                .AsNoTracking()
                .Include(x => x.BikeType)
                .FirstOrDefault(x => x.Id == id) ?? throw new ArgumentNullException($"There is no bikes with id: {id}");
        }

        public void UpdateBike(Bike bike)
        {
            try
            {
                var bikeTypeId = context.BikeType
               .AsNoTracking()
               .FirstOrDefault(x => x.Name == bike.BikeType.Name)?.Id;

                if (!bikeTypeId.HasValue)
                {
                    throw new ArgumentNullException(nameof(bikeTypeId), $"Bike type with name {bike.BikeType.Name} was not found.");
                }

                bike.BikeTypeId = bikeTypeId.Value;
                bike.BikeType.Id = bikeTypeId.Value;

                context.Bike.Update(bike);

                context.SaveChanges();
            }
            finally
            {
                context.Entry(bike.BikeType).State = EntityState.Detached;
            }
        }

        public void DeleteBike(Guid id) => context.Bike
                .Where(b => b.Id == id)
                .ExecuteDelete();
    }
}
