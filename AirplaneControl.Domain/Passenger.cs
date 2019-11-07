using AirplaneControl.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain
{
    public class Passenger:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual Airplane Airplane { get; set; }
    }
}
