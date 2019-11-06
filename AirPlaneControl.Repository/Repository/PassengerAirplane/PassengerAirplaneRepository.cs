using AirplaneControl.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneControl.Repository
{
   public class PassengerAirplaneRepository : RepositoryBase<PassengerAirplane>, IPassengerAirplaneRepository
    {
        public PassengerAirplaneRepository(ApplicationDbContext context) : base(context) { }
    }
    
    
}
