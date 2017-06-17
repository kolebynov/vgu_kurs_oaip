using Domain.Attributes;
using Domain.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    /// <summary>
    /// Забронированный тур.
    /// </summary>
    [Table(nameof(BookedTour))]
    public class BookedTour : BaseEntity
    {
        [LookupField]
        public Contact Contact
        {
            get => GetTypedColumnValue<Contact>(nameof(Contact));
            set => SetColumnValue(nameof(Contact), value);
        }

        [ForeignKey(nameof(Contact)), Column, Required]
        public Guid ContactId
        {
            get => GetTypedColumnValue<Guid>(nameof(ContactId));
            set => SetColumnValue(nameof(ContactId), value);
        }

        [NameColumn]
        public string ContactName
        {
            get => Contact?.GetDisplayColumnValue();
        }

        [LookupField]
        public Tour Tour
        {
            get => GetTypedColumnValue<Tour>(nameof(Tour));
            set => SetColumnValue(nameof(Tour), value);
        }

        [ForeignKey(nameof(Tour)), Column, Required]
        public Guid TourId
        {
            get => GetTypedColumnValue<Guid>(nameof(TourId));
            set => SetColumnValue(nameof(TourId), value);
        }

        [NameColumn]
        public string TourName
        {
            get => Tour?.GetDisplayColumnValue();
        }

        [Required, Column]
        public DateTime Date
        {
            get => GetTypedColumnValue<DateTime>(nameof(Date));
            set => SetColumnValue(nameof(Date), value);
        }
    }
}
