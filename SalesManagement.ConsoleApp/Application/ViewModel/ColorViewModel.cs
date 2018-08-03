using System.ComponentModel.DataAnnotations;

namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class ColorViewModel
    {
        public int Id { get; set; }
        [StringLength(255)] public string Name { get; set; }
        [StringLength(255)] public string Code { get; set; }
    }
}