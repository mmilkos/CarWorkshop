using CarWorkshop.Domain.Entities;
using CarWorkshop.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder 
    {
        private readonly CarWorkshopDbContext _dbContext;
        public CarWorkshopSeeder(CarWorkshopDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task Seed() 
        {
            
            if (await _dbContext.Database.CanConnectAsync()) 
            {
                if (!_dbContext.CarWorkshops.Any())
                {
                    var mazdaAso = new Domain.Entities.CarWorkshop()
                    {
                        Name = "mazda ASO",
                        Description = "Serwis Mazda",
                        ContactDetails = new CarWorkshopContactDetails
                        {
                            City = "Warszawa",
                            Street = "Jana Pawła 2",
                            PostalNumber = "05-077",
                            PhoneNumber = "+48111222333"
                        }
                    };
                    mazdaAso.EncodeName();
                    _dbContext.Add(mazdaAso);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
