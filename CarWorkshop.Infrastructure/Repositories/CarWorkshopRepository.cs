﻿
using CarWorkshop.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.Aplication.CarWorkshop;
using CarWorkshop.Domain.Interfaces;

namespace CarWorkshop.Infrastructure.Repositories
{
    public class CarWorkshopRepository : ICarWorkshopRepository
    {
        private readonly CarWorkshopDbContext _dbContext;

        public CarWorkshopRepository(CarWorkshopDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }
    }
}