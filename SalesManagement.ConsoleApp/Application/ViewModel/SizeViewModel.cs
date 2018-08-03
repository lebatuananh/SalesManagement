using System.ComponentModel.DataAnnotations;

namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class SizeViewMode
    {
        public int Id { get; set; }
        [StringLength(250)] public string Name { get; set; }
    }
}