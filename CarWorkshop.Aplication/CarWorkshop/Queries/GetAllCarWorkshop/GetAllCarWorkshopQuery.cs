using CarWorkshop.Aplication.CarWorkshop;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Aplication.Queries
{
    public class GetAllCarWorkshopQuery : IRequest<IEnumerable<CarWorkshopDto>>
    {

    }
}
