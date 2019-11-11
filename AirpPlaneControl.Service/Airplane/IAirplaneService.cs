using AirplaneControl.Domain;
using AirplaneControl.Domain.Common;
using AirpPlaneControl.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirpPlaneControl.Service
{
    public interface  IAirplaneService:IBaseService<AirPlane>
    {
        IList<AirPlane> GetBookWithAllUsers(int airPlaneId);
    }
}
