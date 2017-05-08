using Domain.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    /// <summary>
    /// Пол
    /// </summary>
    [Table(nameof(Gender))]
    public class Gender : BaseLookup
    {
    }
}
