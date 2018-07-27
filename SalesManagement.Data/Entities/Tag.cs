using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.Infrastructure.SharedKernel;

namespace SalesManagement.Data.Entities
{
    [Table("Tags")]
    public class Tag:DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}