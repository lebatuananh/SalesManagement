using SalesManagement.ConsoleApp.Domain.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required] [StringLength(255)] public string Name { get; set; }

        [Required] public int CategoryId { get; set; }

        [Required] [DefaultValue(0)] public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public decimal OriginalPrice { get; set; }

        [StringLength(255)] public string Description { get; set; }

        public string Content { get; set; }

        [StringLength(255)] public string Tags { get; set; }

        public string Unit { get; set; }

        public Status Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        [StringLength(255)] public string SeoPageTitle { get; set; }

        [StringLength(255)] public string SeoAlias { get; set; }

        [StringLength(255)] public string SeoKeywords { get; set; }

        [StringLength(255)] public string SeoDescription { get; set; }

        public ProductCategoryViewModel ProductCategoryViewModel { set; get; }

        public ICollection<ProductTagViewModel> ProductTags { get; set; }
    }
}