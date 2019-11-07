using AirplaneControl.Domain;
using AirplaneControl.Domain.Validators;
using AirPlaneControl.Repository;
using AirPlaneControl.Repository.Infra;
using AirpPlaneControl.Service;
using FluentValidation;
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
            services.AddScoped<IAirPlaneRepository, AirPlaneRepository>();
            services.AddScoped<IPassengerRepository, PassengerRepository>();

            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Validators
            services.AddScoped<IValidator<Airplane>, AirPlaneValidator>();
            services.AddScoped<IValidator<Passenger>, PassengerValidator>();


            return services;

            

        }
       

    }
}
