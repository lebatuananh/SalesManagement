using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesManagement.Data.Enums;
using SalesManagement.Data.Interfaces;
using SalesManagement.Infrastructure.SharedKernel;

namespace SalesManagement.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        public Product()
        {
            ProductTags = new List<ProductTag>();
        }


        public Product(
            string name,
            int categoryId,
            decimal price,
            decimal? promotionPrice,
            decimal originalPrice,
            string description,
            string content,
            string tags,
            string unit,
            Status status,
            string seoPageTitle,
            string seoAlias,
            string seoKeywords,
            string seoDescription
        )
        {
            Name = name;
            CategoryId = categoryId;
            Price = price;
            PromotionPrice = promotionPrice;
            OriginalPrice = originalPrice;
            Description = description;
            Content = content;
            Tags = tags;
            Unit = unit;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeywords;
            SeoDescription = seoDescription;
        }

        [StringLength(255)] [Required] public string Name { get; set; }

        [Required] public int CategoryId { get; set; }

        [Required] [DefaultValue(0)] public decimal Price { get; set; }

        [Required] public decimal? PromotionPrice { get; set; }

        [Required] public decimal OriginalPrice { get; set; }

        [StringLength(255)] public string Description { get; set; }

        public string Content { get; set; }

        [StringLength(255)] public string Tags { get; set; }

        public string Unit { get; set; }

        public Status Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        [StringLength(255)] public string SeoPageTitle { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        public string SeoAlias { get; set; }

        [StringLength(255)] public string SeoKeywords { get; set; }

        [StringLength(255)] public string SeoDescription { get; set; }

        [ForeignKey("CategoryId")] public virtual ProductCategory ProductCategory { set; get; }

        public ICollection<ProductTag> ProductTags { set; get; }
    }
}