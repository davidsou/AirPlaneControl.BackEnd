using AirplaneControl.Domain;
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
        public PassengerService(IRepositoryBase<Passenger> repository, IUnitOfWork unitOfWork, IValidator<Passenger> validator) 
            : base(repository, unitOfWork, validator)
        {
        }
    }
}
