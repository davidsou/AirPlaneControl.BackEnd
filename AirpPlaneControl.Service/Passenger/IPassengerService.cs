using AirplaneControl.Domain;
using AirplaneControl.Domain.Common;
using AirpPlaneControl.Service.Base;


namespace AirpPlaneControl.Service
{
    public interface IPassengerService : IBaseService<Passenger>
    {
         Result<Passenger> PassengerToAirPlane(PassengerToAirPlane passenger);
    }

    
}
