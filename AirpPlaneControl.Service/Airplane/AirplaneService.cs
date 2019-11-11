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
    public class AirPlaneService : BaseService<AirPlane>, IAirplaneService
    {

        public AirPlaneService(IAirPlaneRepository airplaneRepository, IUnitOfWork unitOfWork, IValidator<AirPlane> validator)
            : base(airplaneRepository, unitOfWork, validator)
        {
        }

        public IList<AirPlane> GetBookWithAllUsers(int airPlaneId)
        {
            var airplanes = _repository
            .Get().Include(x => x.Passengers)
            .Where(x => x.Id == airPlaneId)
            .ToList();

            return airplanes;
        }

    }
}
