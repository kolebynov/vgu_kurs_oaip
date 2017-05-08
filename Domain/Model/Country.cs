using Domain.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    /// <summary>
    /// Страна.
    /// </summary>
    [Table(nameof(Country))]
    public class Country : BaseLookup
    {
    }
}
