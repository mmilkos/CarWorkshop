using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Presistence
{
    public class CarWorkshopDbContext : DbContext
    {
        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options) 
        {

        }
        public DbSet<Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //przekazujemy w ustawienaich, że concatDetails to osobna tabela
           var Entity = modelBuilder.Entity<Domain.Entities.CarWorkshop>();
            Entity.OwnsOne(c => c.ContactDetails);
        }
    }
}
//