using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.ConsoleApp.Domain.Data.Enum;
using SalesManagement.ConsoleApp.Domain.Data.Interfaces;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.SharedKernel;

namespace SalesManagement.ConsoleApp.Domain.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, IDateTracking, ISoftable, ISwitchable
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public ProductCategory(string name, string description, string seoPageTitle, string seoAlias, string seoKeywords, string seoDescription, int sortOrder, Status status)
        {
            Name = name;
            Description = description;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeywords;
            SeoDescription = seoDescription;
            SortOrder = sortOrder;
            Status = status;
        }

        [StringLength(255)] [Required] public string Name { get; set; }
        
        [StringLength(255)] [Required] public string Description { get; set; }
        
        [StringLength(255)] public string SeoPageTitle { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        public string SeoAlias { get; set; }

        [StringLength(255)] public string SeoKeywords { get; set; }
        
        [StringLength(255)] public string SeoDescription { get; set; }
        
        public DateTime DateCreated { get; set; }
        
        public DateTime DateModified { get; set; }
        
        public int SortOrder { get; set; }
        
        public Status Status { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}