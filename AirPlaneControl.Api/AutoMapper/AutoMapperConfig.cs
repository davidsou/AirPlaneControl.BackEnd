using AirplaneControl.Domain;
using AirPlaneControl.Api.ViewModel;
using AutoMapper;


namespace AirPlaneControl.Api.AutoMapper
{
    public class AutoMapperConfig
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AuthorMappingProfile>();
            });
            return config;

        }
    }

    public class AuthorMappingProfile : Profile
    {
        public AuthorMappingProfile()
        {
            CreateMap<Passenger, PassengerVM>();
            CreateMap<AirPlane, AirPlaneVM>();
            CreateMap<PassengerToAirplaneVM, PassengerToAirPlane>()
                .ForMember( dest => dest.AiplaneId, opt => opt.MapFrom(src => src.AirPlaneId )) ;

            CreateMap<AirPlaneVM, AirPlane>().ReverseMap();
            CreateMap<PassengerVM, Passenger>().ReverseMap();
            
        }
    }
}

