using AirPlaneControl.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using AirplaneControl.Domain;

namespace AirPlaneControl.Repository
{
    public class PassengerRepository:RepositoryBase<Passenger>,IPassengerRepository
    {
        public PassengerRepository(ApplicationDbContext context): base(context){}
    }
}
