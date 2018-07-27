using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.Infrastructure.SharedKernel;

namespace SalesManagement.Data.Entities
{
    [Table("ProductQuantities")]
    public class ProductQuantity : DomainEntity<int>
    {
        [Column(Order = 1)] public int ProductId { get; set; }
        
        [Column(Order = 2)] public int SizeId { get; set; }
        
        [Column(Order = 3)] public int ColorId { get; set; }
        
        public int Quantity { get; set; }

        [ForeignKey("ProductId")] public virtual Product Product { get; set; }
        
        [ForeignKey("SizeId")] public virtual Size Size { get; set; }
        
        [ForeignKey("CorlorId")] public virtual Color Color { get; set; }
    }
}