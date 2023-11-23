
using CarWorkshop.Aplication.CarWorkshop.Commands.createWorkshop;
using CarWorkshop.Application.Mappings;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Aplication.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static void AddAplication(this IServiceCollection services) 
        {
            services.AddMediatR(typeof(CreateCarWorkshopCommand));

            services.AddAutoMapper(typeof(CarWorkshopMappingProfile));
        }
    }
}