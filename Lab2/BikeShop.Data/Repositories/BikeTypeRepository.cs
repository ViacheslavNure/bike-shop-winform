using BikeShop.Data.Context;
using BikeShop.Data.Entities;
using BikeShop.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BikeShop.Data.Repositories
{
    public class BikeTypeRepository : IBikeTypeRepository
    {
        private readonly BikeShopDbContext context;

        public BikeTypeRepository(BikeShopDbContext context)
        {
            this.context = context;
        }

        public List<BikeType> GetBikeTypes() => context.BikeType
                .AsNoTracking()
                .ToList();

        public BikeType GetBikeTypeByName(string name) => context.BikeType
                .AsNoTracking()
                .First(x => x.Name == name);

        public void AddBikeType(BikeType bikeType)
        {
            context.BikeType.Add(bikeType);
            context.SaveChanges();
        }

        public void DeleteBikeType(string name) => context.BikeType
        .Where(b => b.Name == name)
        .ExecuteDelete();
    }
}
