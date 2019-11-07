using AirplaneControl.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneControl.Repository
{
    public class AirPlaneRepository : RepositoryBase<Airplane>, IAirPlaneRepository
    {
        public AirPlaneRepository(ApplicationDbContext context) : base(context) { }
    }
}
