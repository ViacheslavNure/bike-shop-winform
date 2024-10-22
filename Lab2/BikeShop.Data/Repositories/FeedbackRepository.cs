using BikeShop.Data.Context;
using BikeShop.Data.Entities;
using BikeShop.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BikeShop.Data.Repositories
{
    internal class FeedbackRepository : IFeedbackRepository
    {
        private readonly BikeShopDbContext context;

        public FeedbackRepository(BikeShopDbContext context)
        {
            this.context = context;
        }

        public void AddFeedback(Feedback feedback)
        {
            context.Feedback.Add(feedback);
            context.SaveChanges();
        }

        public List<Feedback> GetFeedbackByBikeId(Guid id) => context.Feedback
                .AsNoTracking()
                .Where(x => x.BikeId == id)
                .OrderByDescending(x => x.CreationDate)
                .ToList();

        public string GetFeedbackContentById(Guid id) => context.Feedback
                .AsNoTracking()
                .First(x => x.Id == id)
                .Content;
    }
}
