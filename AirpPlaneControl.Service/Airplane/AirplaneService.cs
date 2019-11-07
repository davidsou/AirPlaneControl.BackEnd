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
    public class AirplaneService : BaseService<Airplane>,IAirplaneService
    {
        public AirplaneService(IAirPlaneRepository  airplaneRepository, IUnitOfWork unitOfWork, IValidator<Airplane> validator) 
            : base(airplaneRepository, unitOfWork, validator)
        {
        }
    }
}
