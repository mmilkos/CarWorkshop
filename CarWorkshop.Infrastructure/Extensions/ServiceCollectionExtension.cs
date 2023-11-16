using CarWorkshop.Infrastructure.Presistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CarWorkshop.Infrastructure.Seeders;
using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Repositories;

namespace CarWorkshop.Infrastructure.Extensions
{
   
    public static class ServiceCollectionExtension
    {
        
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            var conectionString = configuration.GetConnectionString("CarWorkshop");

            
            services.AddDbContext<CarWorkshopDbContext>(options => options.UseSqlServer(conectionString));
            
            services.AddScoped<ICarWorkshopRepository, CarWorkshopRepository>();
            services.AddScoped<CarWorkshopSeeder>();
        }
    }
}
