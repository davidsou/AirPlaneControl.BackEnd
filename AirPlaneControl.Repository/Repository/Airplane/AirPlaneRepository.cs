using AirplaneControl.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneControl.Repository
{
    public class AirPlaneRepository : RepositoryBase<AirPlane>, IAirPlaneRepository
    {
        public AirPlaneRepository(ApplicationDbContext context) : base(context) { }
    }
}
