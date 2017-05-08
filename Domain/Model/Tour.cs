using Domain.Attributes;
using Domain.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    /// <summary>
    /// Тур.
    /// </summary>
    [Table(nameof(Tour))]
    public class Tour : BaseEntity
    {
        [LookupField]
        public Country Country { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public Guid CountryId
        {
            get => GetTypedColumnValue<Guid>(nameof(CountryId));
            set => SetColumnValue(nameof(CountryId), value);
        }

        [LookupField]
        public City City { get; set; }

        [Required]
        [ForeignKey(nameof(City))]
        public Guid CityId
        {
            get => GetTypedColumnValue<Guid>(nameof(CityId));
            set => SetColumnValue(nameof(CityId), value);
        }

        public decimal Price
        {
            get => GetTypedColumnValue<decimal>(nameof(Price));
            set => SetColumnValue(nameof(Price), value);
        }
    }
}
