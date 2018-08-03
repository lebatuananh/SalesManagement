using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SalesManagement.ConsoleApp.Domain.Data.Enum;

namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        
        [StringLength(255)] [Required] public string Name { get; set; }

        [StringLength(255)] [Required] public string Description { get; set; }

        [StringLength(255)] public string SeoPageTitle { get; set; }

        [StringLength(255)]
        public string SeoAlias { get; set; }

        [StringLength(255)] public string SeoKeywords { get; set; }

        [StringLength(255)] public string SeoDescription { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int SortOrder { get; set; }

        public Status Status { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }
    }
}