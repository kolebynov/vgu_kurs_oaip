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
        public Contact Contact { get; set; }

        [Required]
        [ForeignKey(nameof(Contact))]
        public Guid ContactId
        {
            get => GetTypedColumnValue<Guid>(nameof(ContactId));
            set => SetColumnValue(nameof(ContactId), value);
        }

        [LookupField]
        public Tour Tour { get; set; }

        [Required]
        [ForeignKey(nameof(Tour))]
        public Guid TourId
        {
            get => GetTypedColumnValue<Guid>(nameof(TourId));
            set => SetColumnValue(nameof(TourId), value);
        }

        [Required]
        public DateTime Date
        {
            get => GetTypedColumnValue<DateTime>(nameof(Date));
            set => SetColumnValue(nameof(Date), value);
        }
    }
}
