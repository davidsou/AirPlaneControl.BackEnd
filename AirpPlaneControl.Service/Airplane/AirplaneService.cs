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
    public class AirplaneService : BaseService<Airplane>, IAirplaneService
    {

        public AirplaneService(IAirPlaneRepository airplaneRepository, IUnitOfWork unitOfWork, IValidator<Airplane> validator)
            : base(airplaneRepository, unitOfWork, validator)
        {
        }

        public IList<Airplane> GetBookWithAllUsers(int airPlaneId)
        {
            var airplanes = _repository
            .Get().Include(x => x.Passengers)
            .Where(x => x.Id == airPlaneId)
            .ToList();

            return airplanes;
        }

    }
}
