using Domain.Attributes;
using Domain.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    /// <summary>
    /// Город.
    /// </summary>
    [Table(nameof(City))]
    public class City : BaseLookup
    {
        [LookupField]
        public Country Country { get; set; }

        [ForeignKey(nameof(Country))]
        public Guid? CountryId
        {
            get => GetTypedColumnValue<Guid?>(nameof(CountryId));
            set => SetColumnValue(nameof(CountryId), value);
        }
    }
}
