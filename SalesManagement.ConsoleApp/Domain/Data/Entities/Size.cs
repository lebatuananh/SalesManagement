using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.SharedKernel;

namespace SalesManagement.ConsoleApp.Domain.Data.Entities
{
    [Table("Sizes")]
    public class Size : DomainEntity<int>
    {
        [StringLength(250)] public string Name { get; set; }
    }
}