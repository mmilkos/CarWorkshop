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
        [Required(ErrorMessage = "Please insert name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage ="Minimum name length is 2 characters")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage ="Please insert description")]
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? PostalNumber { get; set; }
        public string? Street { get; set; }
        [Required(ErrorMessage = "Please insert Phone Number")]
        [Phone]
        public string? PhoneNumber { get; set; }
        public string? EncodedName { get; set; }

    }
}
