using Domain.Attributes;
using Domain.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    /// <summary>
    /// Контакт.
    /// </summary>
    [Table(nameof(Contact))]
    public class Contact : BaseEntity
    {
        [MaxLength(500)]
        [Required]
        public string Name
        {
            get => GetTypedColumnValue<string>(nameof(Name));
            set => SetColumnValue(nameof(Name), value);
        }

        [MaxLength(100)]
        public string FirstName
        {
            get => GetTypedColumnValue<string>(nameof(FirstName));
            set => SetColumnValue(nameof(FirstName), value);
        }

        [MaxLength(100)]
        public string SecondName
        {
            get => GetTypedColumnValue<string>(nameof(SecondName));
            set => SetColumnValue(nameof(SecondName), value);
        }

        [MaxLength(100)]
        public string MiddleName
        {
            get => GetTypedColumnValue<string>(nameof(MiddleName));
            set => SetColumnValue(nameof(MiddleName), value);
        }
    }
}
