using System.ComponentModel.DataAnnotations;

namespace Domain.Model.Abstract
{
    /// <summary>
    /// Базовый справочник.
    /// </summary>
    public abstract class BaseLookup : BaseEntity
    {
        [Required]
        public string Name
        {
            get => GetTypedColumnValue<string>(nameof(Name));
            set => SetColumnValue(nameof(Name), value);
        }
        public string Description
        {
            get => GetTypedColumnValue<string>(nameof(Description));
            set => SetColumnValue(nameof(Description), value);
        }
    }
}