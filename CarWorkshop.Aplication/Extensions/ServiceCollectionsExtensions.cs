using CarWorkshop.Aplication.Mappings;
using CarWorkshop.Aplication.Services;
using CarWorkshop.Application.Mappings;
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
            services.AddScoped<ICarWorkshopService, CarWorkshopService>();

            services.AddAutoMapper(typeof(CarWorkshopMappingProfile));
        }
    }
}