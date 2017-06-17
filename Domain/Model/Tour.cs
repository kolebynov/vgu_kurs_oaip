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
    [Table(nameof(Tour)), DisplayColumn(nameof(Name), nameof(Name))]
    public class Tour : BaseEntity
    {
        [Required, Column]
        public string Name
        {
            get => GetTypedColumnValue<string>(nameof(Name));
            set => SetColumnValue(nameof(Name), value);
        }

        [LookupField]
        public Country Country
        {
            get => GetTypedColumnValue<Country>(nameof(Country));
            set => SetColumnValue(nameof(Country), value);
        }

        [ForeignKey(nameof(Country)), Column, Required]
        public Guid CountryId
        {
            get => GetTypedColumnValue<Guid>(nameof(CountryId));
            set => SetColumnValue(nameof(CountryId), value);
        }

        [NameColumn]
        public string CountryName
        {
            get => Country?.GetDisplayColumnValue();
        }

        [LookupField]
        public City City
        {
            get => GetTypedColumnValue<City>(nameof(City));
            set => SetColumnValue(nameof(City), value);
        }

        [ForeignKey(nameof(City)), Column, Required]
        public Guid CityId
        {
            get => GetTypedColumnValue<Guid>(nameof(CityId));
            set => SetColumnValue(nameof(CityId), value);
        }

        [NameColumn]
        public string CityName
        {
            get => City?.GetDisplayColumnValue();
        }

        [Column]
        public decimal Price
        {
            get => GetTypedColumnValue<decimal>(nameof(Price));
            set => SetColumnValue(nameof(Price), value);
        }
    }
}
