using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesManagement.ConsoleApp.Domain.Data.EF;
using SalesManagement.ConsoleApp.Domain.Data.Entities;
using SalesManagement.ConsoleApp.Domain.Data.Enum;

namespace SalesManagement.ConsoleApp
{
    public static class Program
    {
        //public static IConfiguration Configuration { get; }

        static void Main(string[] args)
        {
//            IServiceCollection services = new ServiceCollection();
//            services.AddDbContext<AppDbContext>(options =>
//                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            using (var context = new AppDbContext())
            {
//                if (!context.Sizes.Any())
//                {
//                    List<Size> listSizes = new List<Size>()
//                    {
//                        new Size() {Name = "XXL"},
//                        new Size() {Name = "XL"},
//                        new Size() {Name = "L"},
//                        new Size() {Name = "M"},
//                        new Size() {Name = "S"},
//                        new Size() {Name = "XS"}
//                    };
//                    context.Sizes.AddRange(listSizes);
//                }
//
//                if (!context.Colors.Any())
//                {
//                    List<Color> listColor = new List<Color>()
//                    {
//                        new Color() {Name="Black", Code="#000000" },
//                        new Color() {Name="White", Code="#FFFFFF"},
//                        new Color() {Name="Red", Code="#ff0000" },
//                        new Color() {Name="Blue", Code="#1000ff" }
//                    };
//                    context.AddRange(listColor);
//                }
//
//                if (!context.ProductCategories.Any())
//                {
//                    List<ProductCategory> listProductCategories = new List<ProductCategory>()
//                    {
//                        new ProductCategory()
//                        {Name = "Men shirt",SeoAlias = "men-shirt",Description = "This is Men shirt",DateCreated = DateTime.Now,Status = Status.Active,SortOrder = 1,Products = new List<Product>()
//                        {
//                            new Product(){Name = "Product1",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-1"},
//                            new Product(){Name = "Product2",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-2"},
//                            new Product(){Name = "Product3",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-3"},
//                            new Product(){Name = "Product4",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-4"},
//                            new Product(){Name = "Product5",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-5"},
//                            new Product(){Name = "Product6",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-6"},
//                            new Product(){Name = "Product7",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-7"},
//                            new Product(){Name = "Product8",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-8"},
//                            new Product(){Name = "Product9",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-9"},
//                            new Product(){Name = "Product10",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-10"},
//                        }
//                            
//                        },
//                        new ProductCategory()
//                        {
//                            Name = "Women shirt",SeoAlias = "women-shirt",Description = "This is Women shirt",DateCreated = DateTime.Now,Status = Status.Active,SortOrder = 2,Products = new List<Product>()
//                            {
//                                new Product(){Name = "Product11",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-11"},
//                                new Product(){Name = "Product12",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-12"},
//                                new Product(){Name = "Product13",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-13"},
//                                new Product(){Name = "Product14",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-14"},
//                                new Product(){Name = "Product15",DateCreated = DateTime.Now,Price = 1000,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-15"},
//                                new Product(){Name = "Product16",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-16"},
//                                new Product(){Name = "Product17",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-17"},
//                                new Product(){Name = "Product18",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-18"},
//                                new Product(){Name = "Product19",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-19"},
//                                new Product(){Name = "Product20",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-20"},
//                            }
//                        },
//                        new ProductCategory()
//                        {
//                            Name="Men shoes",SeoAlias="men-shoes",Description = "This is Men shoes",DateCreated = DateTime.Now,Status=Status.Active ,SortOrder=3,
//                            Products = new List<Product>()
//                            {
//                                new Product(){Name = "Product21",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-21"},
//                                new Product(){Name = "Product22",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-22"},
//                                new Product(){Name = "Product23",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-23"},
//                                new Product(){Name = "Product24",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-24"},
//                                new Product(){Name = "Product25",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-25"},
//                                new Product(){Name = "Product26",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-26"},
//                                new Product(){Name = "Product27",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-27"},
//                                new Product(){Name = "Product28",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-28"},
//                                new Product(){Name = "Product29",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-29"},
//                                new Product(){Name = "Product30",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-30"},
//                            }
//                        },
//                        new ProductCategory()
//                        {
//                            Name="Women shoes",SeoAlias="women-shoes",Description = "This is Women shoes",DateCreated = DateTime.Now,Status=Status.Active ,SortOrder=4,
//                            Products = new List<Product>()
//                            {
//                                new Product(){Name = "Product31",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-31"},
//                                new Product(){Name = "Product32",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-32"},
//                                new Product(){Name = "Product33",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-33"},
//                                new Product(){Name = "Product34",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-34"},
//                                new Product(){Name = "Product35",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-35"},
//                                new Product(){Name = "Product36",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-36"},
//                                new Product(){Name = "Product37",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-37"},
//                                new Product(){Name = "Product38",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-38"},
//                                new Product(){Name = "Product39",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-39"},
//                                new Product(){Name = "Product40",DateCreated = DateTime.Now,Price = 1000,PromotionPrice = 500,OriginalPrice = 900,Status = Status.Active,SeoAlias = "san-pham-40"},
//                            }
//                        }
//                            
//                    };
//                    context.AddRange(listProductCategories);
//                }
                if (!context.ProductImages.Any())
                {
                   
                }
                context.SaveChanges();

//                var query = from p in context.Products
//                    join c in context.ProductCategories on p.CategoryId equals c.Id
//                    select new
//                    {
//                        ProductName=p.Name,
//                        CategoryName=c.Name
//                    };
//                foreach (var list in query)
//                {
//                    Console.WriteLine(list.CategoryName);
//                    Console.WriteLine(list.ProductName);
//                }
                foreach (var listProductCategories in context.ProductCategories.ToList())
                {
                    Console.WriteLine(listProductCategories.Name);
                    var lstproduct = context.Products.FromSql("select * from Products where CategoryId = " + listProductCategories.Id)
                        .ToList();
                    foreach(var item in lstproduct)
                    Console.WriteLine(item.Name);
                   
                }
            }
        }
    }
}