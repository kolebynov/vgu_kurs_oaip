using Domain.Attributes;
using Domain.Model.Abstract;
using System;
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

        [LookupField]
        public virtual Gender Gender
        {
            get => GetTypedColumnValue<Gender>(nameof(Gender));
            set => SetColumnValue(nameof(Gender), value);
        }

        [ForeignKey(nameof(Gender)), Column]
        public Guid GenderId
        {
            get => GetTypedColumnValue<Guid>(nameof(GenderId));
            set => SetColumnValue(nameof(GenderId), value);
        }

        [NameColumn]
        public string GenderName
        {
            get => Gender?.GetDisplayColumnValue();
        }

        public Contact()
        {
            Inserting += ContactInserting;
            Updating += ContactUpdating;
        }

        protected void ContactUpdating(object sender, System.EventArgs e) =>
            ConcatNames();
        protected void ContactInserting(object sender, System.EventArgs e) =>
            ConcatNames();

        private void ConcatNames() =>
            Name = $"{SecondName} {FirstName} {MiddleName}";
    }
}
