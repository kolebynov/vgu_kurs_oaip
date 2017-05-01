using Domain.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Domain.Entities.Abstract
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [HiddenInput(DisplayValue = false)]
        public Guid Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime? CreatedOn { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime? ModifiedOn { get; set; }

        [NavProperty]
        public Contact CreatedBy { get; set; }

        [NavProperty]
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
