using AutoMapper;
using BikeShop.Application.Services.Interfaces;
using BikeShop.Application.ViewModels;
using BikeShop.Data.Entities;
using BikeShop.Data.Repositories.Interfaces;

namespace BikeShop.Application.Services
{
    public class BikeService : IBikeService
    {
        private readonly IMapper mapper;
        private readonly IBikeTypeRepository bikeTypeRepository;
        private readonly IBikeRepository bikeRepository;
        private readonly IFeedbackRepository feedbackRepository;

        public BikeService(
            IMapper mapper,
            IBikeRepository bikeRepository,
            IBikeTypeRepository bikeTypeRepository,
            IFeedbackRepository feedbackRepository)
        {
            this.mapper = mapper;
            this.bikeRepository = bikeRepository;
            this.bikeTypeRepository = bikeTypeRepository;
            this.feedbackRepository = feedbackRepository;
        }

        public void AddBike(BikeViewModel newBike)
        {
            var bikeEntity = mapper.Map<Bike>(newBike);

            if (decimal.TryParse(newBike.Price, out var price))
            {
                bikeEntity.Price = price;
            }
            else
            {
                throw new ArgumentException("Price must be provided in correct format. E.g. 1000.00");
            }

            bikeRepository.AddBike(bikeEntity);
        }

        public void AddBikeType(BikeTypeViewModel bikeType)
        {
            var bikeEntity = mapper.Map<BikeType>(bikeType);

            bikeTypeRepository.AddBikeType(bikeEntity);
        }

        public void AddFeedback(FeedbackViewModel feedback)
        {
            var feedbackEntity = mapper.Map<Feedback>(feedback);

            feedbackRepository.AddFeedback(feedbackEntity);
        }

        public void DeleteBikeById(Guid id)
        {
            bikeRepository.DeleteBike(id);
        }

        public void DeleteBikeTypeByName(string name)
        {
            bikeTypeRepository.DeleteBikeType(name);
        }

        public BikeViewModel GetBikeById(Guid id)
        {
            var bikeEntity = bikeRepository.GetBikeById(id);

            return mapper.Map<BikeViewModel>(bikeEntity);
        }

        public List<BikeViewModel> GetBikesList()
        {
            return bikeRepository
                .GetBikeList()
                .Select(mapper.Map<BikeViewModel>)
                .ToList();
        }

        public BikeTypeViewModel GetBikeTypeByName(string name)
        {
            var bikeType = bikeTypeRepository.GetBikeTypeByName(name);

            return mapper.Map<BikeTypeViewModel>(bikeType);
        }

        public List<BikeTypeViewModel> GetBikeTypesList()
        {
            return bikeTypeRepository
                .GetBikeTypes()
                .Select(mapper.Map<BikeTypeViewModel>)
                .ToList();
        }

        public string GetFeedbackContentById(Guid id)
        {
            return feedbackRepository.GetFeedbackContentById(id);
        }

        public List<FeedbackViewModel> GetFeedbacksByBikeId(Guid bikeId)
        {
            return feedbackRepository
                .GetFeedbackByBikeId(bikeId)
                .Select(mapper.Map<FeedbackViewModel>)
                .ToList();
        }

        public void UpdateBike(BikeViewModel bike)
        {
            var bikeEntity = mapper.Map<Bike>(bike);

            if (decimal.TryParse(bike.Price, out var price))
            {
                bikeEntity.Price = price;
            }
            else
            {
                throw new ArgumentException("Price must be provided in correct format. E.g. 1000.00");
            }

            bikeRepository.UpdateBike(bikeEntity);
        }
    }
}
