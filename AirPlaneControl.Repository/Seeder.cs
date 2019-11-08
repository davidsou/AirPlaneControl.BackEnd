using AirplaneControl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPlaneControl.Repository
{
    public class Seeder
    {
        private readonly ApplicationDbContext _context;
        public Seeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (!_context.Airplanes.Any() && !_context.Passengers.Any())
            {
                var airplane01 = new Airplane
                {
                    Name = "Boeing 732",
                    QuantityOfSeats = 50,
                    Passengers = new List<Passenger>
                    {
                        new Passenger
                        {
                            Name = "Fulano de Tal",
                            Email = "fulanodetal@airplanecontrol.com"
                        },

                        new Passenger
                        {
                             Name = "Beltrano de Tal",
                             Email = "beltranodetal@airplanecontrol.com"
                        },
                        new Passenger
                        {
                            Name = "Ciclano de Tal",
                            Email = "ciclanodetal@airplanecontrol.com"
                        },
                    }

                };


                var airplane02 = new Airplane
                {
                    Name = "Embraer E190 ",
                    QuantityOfSeats = 50,
                };

                var airplane03 = new Airplane
                {
                    Name = "Air Bus  360",
                    QuantityOfSeats = 50,
                };

                var passenger01 = new Passenger
                {
                    Name = "Alexandre da Silva",
                    Email = "fulanodetal@airplanecontrol.com"
                };

                var passenger02 = new Passenger
                {
                    Name = "Bernardo dos Santos",
                    Email = "beltranodetal@airplanecontrol.com"
                };

                var passenger03 = new Passenger
                {
                    Name = "Carlos Souza",
                    Email = "ciclanodetal@airplanecontrol.com"
                };

                _context.Airplanes.AddRange(airplane01, airplane02, airplane03);
                _context.Passengers.AddRange(passenger01, passenger02, passenger03);
                _context.SaveChanges();
            }
        }
    }
}
