using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.Aplication.CarWorkshop;
using MediatR;

namespace CarWorkshop.Aplication.CarWorkshop.Commands.createWorkshop
{
    public class CreateCarWorkshopCommand : CarWorkshopDto, IRequest<Unit>
    {
    }
}
