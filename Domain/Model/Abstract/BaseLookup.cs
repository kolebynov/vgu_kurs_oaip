using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Abstract
{
    /// <summary>
    /// Базовый справочник.
    /// </summary>
    [DisplayColumn(nameof(Name), nameof(Name))]
    public abstract class BaseLookup : BaseEntity
    {
        [Required, Column]
        public string Name
        {
            get => GetTypedColumnValue<string>(nameof(Name));
            set => SetColumnValue(nameof(Name), value);
        }
        [Column]
        public string Description
        {
            get => GetTypedColumnValue<string>(nameof(Description));
            set => SetColumnValue(nameof(Description), value);
        }
    }
}