using Domain.Attributes;
using Domain.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Tour : BaseEntity
    {
        [NavProperty]
        public Country Country { get; set; }

        [Required]
        public Guid CountryId { get; set; }

        [NavProperty]
        public City City { get; set; }

        [Required]
        public Guid CityId { get; set; }

        public decimal Price { get; set; }
    }
}
