using AirPlaneControl.Repository;
using AirPlaneControl.Repository.Infra;
using AirpPlaneControl.Service;
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
            //services
            services.AddScoped<IAirplaneService, AirplaneService>();
            services.AddScoped<IPassengerService, PassengerService>();

            //repositories
            services.AddScoped<IAirplaneRepository, AirPlaneRepository>();
            services.AddScoped<IPassengerRepository, PassengerRepository>();

            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
       

    }
}
