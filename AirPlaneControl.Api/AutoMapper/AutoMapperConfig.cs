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
            CreateMap<Airplane, AirPlaneVM>();
            CreateMap<PassangerToAirplaneVM, PassengerToAirPlane>();

            CreateMap<AirPlaneVM, Airplane>().ReverseMap();
            CreateMap<PassengerVM, Passenger>().ReverseMap();
            
        }
    }
}

