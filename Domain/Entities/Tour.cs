using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tour : BaseEntity
    {
        public Country Country { get; set; }
        [Required]
        public Guid CountryId { get; set; }
        public City City { get; set; }
        [Required]
        public Guid CityId { get; set; }
        public decimal Price { get; set; }
    }
}
