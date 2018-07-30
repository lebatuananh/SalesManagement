using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.SharedKernel;

namespace SalesManagement.ConsoleApp.Domain.Data.Entities
{
    [Table("Tags")]
    public class Tag:DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}