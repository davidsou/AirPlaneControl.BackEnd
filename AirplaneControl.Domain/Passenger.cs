using AirplaneControl.Domain.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain
{
    public class Passenger:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }        
        public int? AirplaneId { get; set; }
        [JsonIgnore]
        public virtual AirPlane Airplane { get; set; }
    }
}
