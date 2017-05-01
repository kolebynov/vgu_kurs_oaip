using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Domain.Entities
{
    public class BaseEntity
    {
        [HiddenInput(DisplayValue = false)]
        public Guid Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime? CreatedOn { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime? ModifiedOn { get; set; }
        public Contact CreatedBy { get; set; }
        public Contact ModifiedBy { get; set; }
        [HiddenInput(DisplayValue = false)]
        [ForeignKey("CreatedBy")]
        public Guid? CreatedById { get; set; }
        [HiddenInput(DisplayValue = false)]
        [ForeignKey("ModifiedBy")]
        public Guid? ModifiedById { get; set; }

        [InverseProperty("CreatedBy")]
        protected ICollection<Contact> CreatedByCollection { get; set; }
        [InverseProperty("ModifiedBy")]
        protected ICollection<Contact> ModifiedByCollection { get; set; }
    }
}
