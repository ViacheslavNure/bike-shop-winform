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

        public void AddBike(Bike bike)
        {
            var bikeTypeId = context.BikeType.AsNoTracking().FirstOrDefault(x => x.Name == bike.BikeType.Name)?.Id;

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

        public void UpdateBike(Bike bike)
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
            context.Entry(bike.BikeType).State = EntityState.Detached;
        }

        public List<BikeType> GetBikeTypes()
        {
            return context.BikeType
                .AsNoTracking()
                .ToList();
        }

        public BikeType GetBikeTypeByName(string name)
        {
            return context.BikeType
                .AsNoTracking()
                .First(x => x.Name == name);
        }

        public void AddBikeType(BikeType bikeType)
        {
            context.BikeType.Add(bikeType);
            context.SaveChanges();
        }

        public void DeleteBike(Guid id)
        {
            context.Bike
                .Where(b => b.Id == id)
                .ExecuteDelete();
        }
        public void DeleteBikeType(string name)
        {
            context.BikeType
                .Where(b => b.Name == name)
                .ExecuteDelete();
        }

        public void AddFeedback(Feedback feedback)
        {
            context.Feedback.Add(feedback);
            context.SaveChanges();
        }

        public List<Feedback> GetFeedbackByBikeId(Guid id)
        {
            return context.Feedback.AsNoTracking().Where(x=>x.BikeId == id).ToList();
        }
    }
}
