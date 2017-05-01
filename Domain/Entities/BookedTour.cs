using Domain.Attributes;
using Domain.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BookedTour : BaseEntity
    {
        [NavProperty]
        public Contact Contact { get; set; }

        [Required]
        public Guid ContactId { get; set; }

        [NavProperty]
        public Tour Tour { get; set; }

        [Required]
        public Guid TourId { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
