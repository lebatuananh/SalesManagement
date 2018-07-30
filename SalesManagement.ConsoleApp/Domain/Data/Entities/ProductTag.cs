using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.SharedKernel;

namespace SalesManagement.ConsoleApp.Domain.Data.Entities
{
    [Table("ProductTags")]
    public class ProductTag:DomainEntity<int>
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string TagId { get; set; }

        [ForeignKey("ProductId")] public virtual Product Product { get; set; }
        
        [ForeignKey("TagId")] public virtual Tag Tag { get; set; }
    }
}