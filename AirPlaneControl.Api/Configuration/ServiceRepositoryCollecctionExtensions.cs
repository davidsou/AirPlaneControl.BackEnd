using AirPlaneControl.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPlaneControl.Api.Configuration
{
    public static class ServiceRepositoryCollecctionExtensions
    {

        public static IServiceCollection RegisterRepositoryServices( this IServiceCollection services)
        {
            services.AddScoped<IAirplaneRepository, AirPlaneRepository>();
            services.AddScoped<IPassengerRepository, PassengerRepository>();

            return services;
        }
       

    }
}
