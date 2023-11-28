using CarWorkshop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Aplication.CarWorkshop.Commands.EditCarWorkshop
{
    public class EditCarWorkshopCommandHandler : IRequestHandler<EditCarWorkshopCommand>
    {
        private readonly ICarWorkshopRepository _Repository;
        public EditCarWorkshopCommandHandler(ICarWorkshopRepository carWorkshopRepository) 
        {
            _Repository = carWorkshopRepository;
        }  
        public async Task<Unit> Handle(EditCarWorkshopCommand request, CancellationToken cancellationToken)
        {
            var carWorkshop = await _Repository.GetByEncodedName(request.EncodedName);

            carWorkshop.Description = request.Description;
            carWorkshop.ContactDetails.City = request.City;
            carWorkshop.ContactDetails.PhoneNumber = request.PhoneNumber;
            carWorkshop.ContactDetails.PostalNumber = request.PostalNumber;
            carWorkshop.ContactDetails.Street = request.Street;

            await  _Repository.Commit();
            return Unit.Value;
            
        }
    }
}
