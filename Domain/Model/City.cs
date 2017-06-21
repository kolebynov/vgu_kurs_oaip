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
        public virtual Country Country
        {
            get => GetTypedColumnValue<Country>(nameof(Country));
            set => SetColumnValue(nameof(Country), value);
        }

        [ForeignKey(nameof(Country)), Column]
        public Guid? CountryId
        {
            get => GetTypedColumnValue<Guid?>(nameof(CountryId));
            set => SetColumnValue(nameof(CountryId), value);
        }

        [NameColumn]
        public string CountryName
        {
            get => Country?.GetDisplayColumnValue();
        }
    }
}
