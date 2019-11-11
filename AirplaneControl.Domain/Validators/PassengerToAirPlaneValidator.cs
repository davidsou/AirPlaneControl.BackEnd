using FluentValidation;


namespace AirplaneControl.Domain.Validators
{
    public class PassengerToAirPlaneValidator: AbstractValidator<PassengerToAirPlane>
    {
        private const string RequiredPassenger = "A valid Passenger is required";
        private const string RequiredAirPlane = "A valid AirPlane is required";

        public PassengerToAirPlaneValidator()
        {
            RuleFor(x => x.AiplaneId)
            .GreaterThan(0)
            .WithMessage(RequiredAirPlane);            


            RuleFor(x => x.PassengerId)
            .GreaterThan(0)
            .WithMessage(RequiredPassenger);
        }
       
    }
}
