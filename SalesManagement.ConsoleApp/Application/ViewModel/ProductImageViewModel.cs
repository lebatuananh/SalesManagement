using System.ComponentModel.DataAnnotations;

namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public ProductViewModel Product { get; set; }

        [StringLength(255)] public string Path { get; set; }

        [StringLength(255)] public string Caption { get; set; }
    }
}