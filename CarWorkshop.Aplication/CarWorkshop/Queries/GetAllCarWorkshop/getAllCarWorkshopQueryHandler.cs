using AutoMapper;
using CarWorkshop.Aplication.Queries;
using CarWorkshop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Aplication.CarWorkshop.Queries.GetAllCarWorkshop
{
    internal class getAllCarWorkshopQueryHandler : IRequestHandler<GetAllCarWorkshopQuery, IEnumerable<CarWorkshopDto>>
    {
        private readonly ICarWorkshopRepository _carWorkshopRepository;
        private readonly IMapper _mapper;

        public getAllCarWorkshopQueryHandler(ICarWorkshopRepository carWorkshopRepository, IMapper mapper)
        {
            _carWorkshopRepository = carWorkshopRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CarWorkshopDto>> Handle(GetAllCarWorkshopQuery request, CancellationToken cancellationToken)
        {
            var carWorkshops = await _carWorkshopRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<CarWorkshopDto>>(carWorkshops);
            return dtos;
        }
    }
}
