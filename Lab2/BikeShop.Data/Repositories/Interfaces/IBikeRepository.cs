using BikeShop.Data.Entities;

namespace BikeShop.Data.Repositories.Interfaces
{
    public interface IBikeRepository
    {
        void AddBike(Bike bike);

        List<Bike> GetBikeList();

        Bike GetBikeById(Guid id);

        void UpdateBike(Bike bike);

        void DeleteBike(Guid id);
    }
}
