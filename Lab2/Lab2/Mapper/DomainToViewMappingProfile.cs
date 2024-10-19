using AutoMapper;
using Lab2.DbConnection.Entities;
using Lab2.ViewModels;

namespace Lab2.Mapper
{
    public class DomainToViewMappingProfile : Profile
    {
        public DomainToViewMappingProfile()
        {
            CreateMap<Bike, BikeViewModel>().ReverseMap();
            CreateMap<BikeType, BikeTypeViewModel>().ReverseMap();
            CreateMap<Feedback, FeedbackViewModel>()
                .ForMember(x => x.Content, opt => opt.MapFrom(x => $"{x.Content.Take(40)}..."));

            CreateMap<FeedbackViewModel, Feedback>()
                .ForMember(x => x.CreationDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
