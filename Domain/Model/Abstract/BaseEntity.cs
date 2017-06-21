using Domain.Attributes;
using System;
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
        [Key, Column(Order = 0), HiddenInput(DisplayValue = false), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id
        {
            get => GetTypedColumnValue<Guid>(nameof(Id));
            set => SetColumnValue(nameof(Id), value);
        }

        [Column(Order = 1), HiddenInput(DisplayValue = false)]
        public DateTime? CreatedOn
        {
            get => GetTypedColumnValue<DateTime?>(nameof(CreatedOn));
            set => SetColumnValue(nameof(CreatedOn), value);
        }

        [Column(Order = 3), HiddenInput(DisplayValue = false)]
        public DateTime? ModifiedOn
        {
            get => GetTypedColumnValue<DateTime?>(nameof(ModifiedOn));
            set => SetColumnValue(nameof(ModifiedOn), value);
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
