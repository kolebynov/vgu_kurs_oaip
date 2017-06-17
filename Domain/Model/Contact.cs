using Domain.Attributes;
using Domain.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Domain.Model
{
    /// <summary>
    /// Контакт.
    /// </summary>
    [Table(nameof(Contact)), DisplayColumn(nameof(Name), nameof(Name))]
    public class Contact : BaseEntity
    {
        [MaxLength(500), HiddenInput(DisplayValue = false), Column]
        public string Name
        {
            get => GetTypedColumnValue<string>(nameof(Name));
            set => SetColumnValue(nameof(Name), value);
        }

        [MaxLength(100), Column]
        public string FirstName
        {
            get => GetTypedColumnValue<string>(nameof(FirstName));
            set => SetColumnValue(nameof(FirstName), value);
        }

        [MaxLength(100), Column]
        public string SecondName
        {
            get => GetTypedColumnValue<string>(nameof(SecondName));
            set => SetColumnValue(nameof(SecondName), value);
        }

        [MaxLength(100), Column]
        public string MiddleName
        {
            get => GetTypedColumnValue<string>(nameof(MiddleName));
            set => SetColumnValue(nameof(MiddleName), value);
        }
    }
}
