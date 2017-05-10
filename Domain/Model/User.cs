using Domain.Attributes;
using Domain.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table(nameof(User))]
    public class User : BaseEntity
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

        [Required]
        public string Password
        {
            get => GetTypedColumnValue<string>(nameof(Password));
            set => SetColumnValue(nameof(Password), value);
        }
    }
}
