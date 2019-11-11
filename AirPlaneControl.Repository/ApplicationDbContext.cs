using AirplaneControl.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AirPlaneControl.Repository
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public ApplicationDbContext() { }

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet <AirPlane> Airplanes { get; set; }

        

    }
}
