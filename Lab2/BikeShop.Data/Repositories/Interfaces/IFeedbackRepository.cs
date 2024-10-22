using BikeShop.Data.Entities;

namespace BikeShop.Data.Repositories.Interfaces
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);

        List<Feedback> GetFeedbackByBikeId(Guid id);

        string GetFeedbackContentById(Guid id);
    }
}
