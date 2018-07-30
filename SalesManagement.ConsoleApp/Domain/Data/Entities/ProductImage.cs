using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.SharedKernel;

namespace SalesManagement.ConsoleApp.Domain.Data.Entities
{
    [Table("ProductImages")]
    public class ProductImage : DomainEntity<int>
    {
        public int ProductId { get; set; }
        
        [ForeignKey("ProductId")] public virtual Product Product { get; set; }

        [StringLength(255)] public string Path { get; set; }

        [StringLength(255)] public string Caption { get; set; }
    }
}