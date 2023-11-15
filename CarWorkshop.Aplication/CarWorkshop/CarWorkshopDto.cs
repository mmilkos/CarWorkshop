using CarWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Aplication.CarWorkshop
{
    public class CarWorkshopDto
    {
      
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? PostalNumber { get; set; }
        public string? Street { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EncodedName { get; set; }

    }
}
