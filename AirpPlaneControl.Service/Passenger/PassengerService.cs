using AirplaneControl.Domain;
using AirplaneControl.Domain.Common;
using AirplaneControl.Domain.Exceptions;
using AirPlaneControl.Repository;
using AirPlaneControl.Repository.Infra;
using AirpPlaneControl.Service.Base;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirpPlaneControl.Service
{
    public class PassengerService : BaseService<Passenger>, IPassengerService
    {
        private object objlock = new object();
        private readonly IAirplaneService _airplane;
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

            lock (objlock)
            {
                var airplane = _airplane.Get(passengerToAirPlane.AiplaneId);

                if (airplane == null || airplane?.ReservedSeats == airplane.QuantityOfSeats)
                    throw new AirplaneControlException("Airplane without seats avaliable");

                var passenger = _repository.Get(passengerToAirPlane.PassengerId);
                if (passenger == null)
                    throw new AirplaneControlException("Passenger not exist");

                if (passenger.AirplaneId >0)
                    throw new AirplaneControlException("Passenger already have a seat");

                airplane.ReservedSeats =  airplane.ReservedSeats + 1 ;
                
                passenger.Airplane = airplane;

                _repository.Update(passenger);

                return new Result<Passenger>(passenger);
            }

        }

        public Result<Passenger> ChangePassanger(PassengerToAirPlane passengerToAirPlane)
        {
            var result = new Result<Passenger>(_passengerToAirPlaneValidador.Validate<PassengerToAirPlane>(passengerToAirPlane));

            if (!result.Success)
                return result;

            var passenger = _repository.Get().Include(x => x.Airplane)
                .Where(y => y.Id == passengerToAirPlane.PassengerId).FirstOrDefault();
            
            if(passenger== null)
                throw new AirplaneControlException("Passenger not exist");

            

            var airplane = _airplane.Get(passengerToAirPlane.AiplaneId);

            if (airplane == null || airplane?.ReservedSeats == airplane.QuantityOfSeats)
                throw new AirplaneControlException("Airplane without seats avaliable");

            var updateairplane = passenger.Airplane;

            updateairplane.ReservedSeats = updateairplane.ReservedSeats - 1;
            _airplane.Update(updateairplane);

            airplane.ReservedSeats = airplane.ReservedSeats + 1;
            passenger.Airplane = airplane;
            
            _repository.Update(passenger);

            return new Result<Passenger>(passenger);


        }
    }
}
