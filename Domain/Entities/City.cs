using Domain.Attributes;
using Domain.Entities.Abstract;
using System;

namespace Domain.Entities
{
    public class City : BaseLookup
    {
        [NavProperty]
        public Country Country { get; set; }

        public Guid? CountryId { get; set; }
    }
}
