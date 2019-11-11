using AirplaneControl.Domain;
using AirplaneControl.Domain.Common;
using AirplaneControl.Domain.Exceptions;
using AirPlaneControl.Repository;
using AirPlaneControl.Repository.Infra;
using AirpPlaneControl.Service.Base;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirpPlaneControl.Service
{
    public class PassengerService : BaseService<Passenger>,IPassengerService
    {
        private object objlock = new object();
        private readonly IAirplaneService _airplane ;
        private readonly IValidator<PassengerToAirPlane> _passengerToAirPlaneValidador;
        public PassengerService(IAirplaneService airplane, IPassengerRepository repository, IUnitOfWork unitOfWork
                                , IValidator<Passenger> validator, IValidator<PassengerToAirPlane> passengerToAirPlaneValidador) 
            : base(repository, unitOfWork, validator)
        {
            _airplane = airplane;
            _passengerToAirPlaneValidador = passengerToAirPlaneValidador;
        }



        public Result<Passenger> PassengerToAirPlane(PassengerToAirPlane passengerToAirPlane)
        {

            var result = new Result<Passenger>(_passengerToAirPlaneValidador.Validate<PassengerToAirPlane>(passengerToAirPlane));

            if (!result.Success)
                return result;
                //throw new AirplaneControlException(string.Join(',',result.Messages));

            lock (objlock)
            {
                var airplane = _airplane.Get(passengerToAirPlane.AiplaneId);

                if (airplane == null || airplane?.QuantityOfSeats <= 0)
                    throw new AirplaneControlException("Airplane without seats");

                var passenger = _repository.Get(passengerToAirPlane.PassengerId);
                if ( passenger == null)
                    throw new AirplaneControlException("Passenger not exist");

                airplane.QuantityOfSeats--;
                passenger.Airplane = airplane;

                _repository.Update(passenger);

                return new Result<Passenger>(passenger);
            }
       
        }
    }
}
