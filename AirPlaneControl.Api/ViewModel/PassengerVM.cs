using AirplaneControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPlaneControl.Api.ViewModel
{
    public class PassengerVM
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int AirplaneId { get; set; }
        public virtual Airplane Airplane { get; set; }
    }
}
