﻿﻿using AutoMapper;
using CarWorkshop.Aplication.CarWorkshop;
using CarWorkshop.Aplication.CarWorkshop.Commands.EditCarWorkshop;
using CarWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Mappings
{
    public class CarWorkshopMappingProfile : Profile
    {
        public CarWorkshopMappingProfile()
        {
            CreateMap<CarWorkshopDto, Domain.Entities.CarWorkshop>()
                .ForMember(e => e.ContactDetails, opt => opt.MapFrom(src => new CarWorkshopContactDetails()
                {
                    City = src.City,
                    PhoneNumber = src.PhoneNumber,
                    PostalNumber = src.PostalNumber,
                    Street = src.Street,
                })); 

            CreateMap<Domain.Entities.CarWorkshop, CarWorkshopDto>()
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.ContactDetails.City))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.ContactDetails.PhoneNumber))
                .ForMember(dto => dto.PostalNumber, opt => opt.MapFrom(src => src.ContactDetails.PostalNumber))
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.ContactDetails.Street));

            CreateMap<CarWorkshopDto, EditCarWorkshopCommand>();
        }
    }
}