using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Abstract
{
    public abstract class BaseLookup : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}