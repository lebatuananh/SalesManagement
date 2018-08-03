using System.ComponentModel.DataAnnotations;

namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class TagViewModel
    {
        public string TagId { get; set; }
        [MaxLength(50)] [Required] public string Name { get; set; }
    }
}