using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BookedTour : BaseEntity
    {
        public Contact Contact { get; set; }
        [Required]
        public Guid ContactId { get; set; }
        public Tour Tour { get; set; }
        [Required]
        public Guid TourId { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
