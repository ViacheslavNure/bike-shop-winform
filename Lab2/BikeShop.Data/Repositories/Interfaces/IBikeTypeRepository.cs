using BikeShop.Data.Entities;

namespace BikeShop.Data.Repositories.Interfaces
{
    public interface IBikeTypeRepository
    {
        List<BikeType> GetBikeTypes();

        BikeType GetBikeTypeByName(string name);

        void AddBikeType(BikeType bikeType);

        void DeleteBikeType(string name);
    }
}
