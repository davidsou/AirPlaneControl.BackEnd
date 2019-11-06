using AirplaneControl.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneControl.Repository.Mapping
{
    public class PassengerAirplaneMap
    {
        public PassengerAirplaneMap(EntityTypeBuilder<PassengerAirplane> entityBuilder)
        {
            entityBuilder.HasKey(t => new { t.Id, t.AirplaneId, t.PassengerId });

           

        }
    }
}
