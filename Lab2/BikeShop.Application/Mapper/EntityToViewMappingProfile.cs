using AutoMapper;
using BikeShop.Application.ViewModels;
using BikeShop.Data.Entities;

namespace BikeShop.Application.Mapper
{
    public class EntityToViewMappingProfile : Profile
    {
        public EntityToViewMappingProfile()
        {
            CreateMap<Bike, BikeViewModel>()
                    .ForMember(x => x.Price, opt => opt.MapFrom(x => x.Price.ToString("F2")));

            CreateMap<BikeType, BikeTypeViewModel>()
                    .ReverseMap();
            CreateMap<Feedback, FeedbackViewModel>()
                    .ForMember(x => x.Content, opt => opt.MapFrom(x => GetMinifiedContent(x.Content)));

            CreateMap<BikeViewModel, Bike>()
                    .ForMember(x => x.Price, opt => opt.Ignore())
                    .ForMember(x => x.Feedbacks, opt => opt.Ignore());

            CreateMap<FeedbackViewModel, Feedback>()
                    .ForMember(x => x.CreationDate, opt => opt.MapFrom(x => DateTime.Now))
                    .ForMember(x => x.Bike, opt => opt.Ignore());
        }

        private string GetMinifiedContent(string content)
        {
            const int maxLengthOfMimifiedContent = 50;
            if (content.Length > maxLengthOfMimifiedContent)
            {
                return $"{string.Concat(content.Take(maxLengthOfMimifiedContent))}...";
            }

            return content;
        }
    }
}
