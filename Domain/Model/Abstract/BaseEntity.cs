using Domain.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Domain.Model.Abstract
{
    /// <summary>
    /// Базовый объект.
    /// </summary>
    public abstract class BaseEntity : BaseModel
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id
        {
            get => GetTypedColumnValue<Guid>(nameof(Id));
            set => SetColumnValue(nameof(Id), value);
        }

        [Column(Order = 1)]
        public DateTime? CreatedOn
        {
            get => GetTypedColumnValue<DateTime?>(nameof(CreatedOn));
            set => SetColumnValue(nameof(CreatedOn), value);
        }

        [Column(Order = 3)]
        public DateTime? ModifiedOn
        {
            get => GetTypedColumnValue<DateTime?>(nameof(ModifiedOn));
            set => SetColumnValue(nameof(ModifiedOn), value);
        }

        [LookupField]
        public Contact CreatedBy { get; set; }

        [ForeignKey(nameof(CreatedBy))]
        [Column(Order = 2)]
        public Guid? CreatedById
        {
            get => GetTypedColumnValue<Guid?>(nameof(CreatedById));
            set => SetColumnValue(nameof(CreatedById), value);
        }

        [LookupField]
        public Contact ModifiedBy { get; set; }

        [ForeignKey(nameof(ModifiedBy))]
        [Column(Order = 4)]
        public Guid? ModifiedById
        {
            get => GetTypedColumnValue<Guid?>(nameof(ModifiedById));
            set => SetColumnValue(nameof(ModifiedById), value);
        }

        public BaseEntity()
        {
            Inserting += BaseEntityInserting;
            Updating += BaseEntityUpdating;
        }

        protected void BaseEntityInserting(object sender, EventArgs e)
        {
            BaseEntity entity = (BaseEntity)sender;
            entity.CreatedOn = DateTime.Now;
            entity.ModifiedOn = DateTime.Now;
            if (Id == Guid.Empty)
                Id = Guid.NewGuid();
        }
        protected void BaseEntityUpdating(object sender, EventArgs e)
        {
            BaseEntity entity = (BaseEntity)sender;
            entity.ModifiedOn = DateTime.Now;
        }
    }
}
