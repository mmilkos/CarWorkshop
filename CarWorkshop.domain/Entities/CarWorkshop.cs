using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Domain.Entities
{
    public class CarWorkshop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public CarWorkshopContactDetails ContactDetails { get; set; } = new CarWorkshopContactDetails()!;
        public string EncodedName { get; set; } = default!;
        public void EncodeName() 
        {
            EncodedName = Name.ToLower().Replace(" ","-");
        }
    }
}
