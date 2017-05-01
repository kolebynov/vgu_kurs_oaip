using System;

namespace Domain.Entities
{
    public class City : BaseLookup
    {
        public Country Country { get; set; }
        public Guid? CountryId { get; set; }
    }
}
