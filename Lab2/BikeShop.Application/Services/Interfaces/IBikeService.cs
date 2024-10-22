using BikeShop.Application.ViewModels;

namespace BikeShop.Application.Services.Interfaces
{
    public interface IBikeService
    {
        void AddBike(BikeViewModel newBike);

        BikeViewModel GetBikeById(Guid id);

        List<BikeViewModel> GetBikesList();

        void UpdateBike(BikeViewModel bike);

        BikeTypeViewModel GetBikeTypeByName(string name);

        List<BikeTypeViewModel> GetBikeTypesList();

        void AddBikeType(BikeTypeViewModel bikeType);

        void DeleteBikeById(Guid id);

        void DeleteBikeTypeByName(string name);

        void AddFeedback(FeedbackViewModel feedback);

        string GetFeedbackContentById(Guid id);

        List<FeedbackViewModel> GetFeedbacksByBikeId(Guid bikeId);
    }
}
