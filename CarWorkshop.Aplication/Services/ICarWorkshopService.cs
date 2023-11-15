using CarWorkshop.Aplication.CarWorkshop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Aplication.Services
{
    public interface ICarWorkshopService
    {
        Task Create(CarWorkshopDto carWorkshopDto);
    }
}
