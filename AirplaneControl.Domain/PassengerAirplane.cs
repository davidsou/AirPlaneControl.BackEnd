using AirplaneControl.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain
{
    public class PassengerAirplane: BaseEntity
    {
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int AirplaneId { get; set; }
        public AirPlane Airplane { get; set; }
        public string Description { get; set; }

               
    }
}
