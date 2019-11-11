using AirplaneControl.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneControl.Repository.Mapping
{
    public class AirPlaneMap        
    {
        public AirPlaneMap(EntityTypeBuilder<AirPlane> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id );
            entityBuilder.Property(t => t.Name).HasMaxLength(100).IsRequired();
            entityBuilder.Property(t => t.QuantityOfSeats).IsRequired();
            entityBuilder.Property(t => t.ReservedSeats).HasDefaultValue(0);
        }
    }
}
