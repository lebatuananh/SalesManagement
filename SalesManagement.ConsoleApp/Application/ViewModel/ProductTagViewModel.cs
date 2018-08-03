using System.ComponentModel.DataAnnotations;

namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class ProductTagViewModel
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }

        [StringLength(50)] [Required] public string TagId { get; set; }

        public ProductViewModel Product { get; set; }

        public TagViewModel Tag { get; set; }
    }
}