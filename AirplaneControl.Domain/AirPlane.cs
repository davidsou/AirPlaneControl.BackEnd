using AirplaneControl.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain
{
    public class AirPlane:BaseEntity
    {
        public string Name { get; set; }
        public int QuantityOfSeats { get; set; }  
        public int ReservedSeats { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
    }
}
