using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Contact", Schema = "dbo")]
    public class Contact : BaseEntity
    {
        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string SecondName { get; set; }
        [MaxLength(100)]
        public string MiddleName { get; set; }
    }
}
