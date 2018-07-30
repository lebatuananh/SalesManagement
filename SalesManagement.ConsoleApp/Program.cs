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
                if (!context.Sizes.Any())
                {
                    List<Size> listSizes = new List<Size>()
                    {
                        new Size() {Name = "XXL"},
                        new Size() {Name = "XL"},
                        new Size() {Name = "L"},
                        new Size() {Name = "M"},
                        new Size() {Name = "S"},
                        new Size() {Name = "XS"}
                    };
                    context.Sizes.AddRange(listSizes);
                }

                if (!context.Colors.Any())
                {
                    List<Color> listColor = new List<Color>()
                    {
                        new Color() {Name = "Black", Code = "#000000"},
                        new Color() {Name = "White", Code = "#FFFFFF"},
                        new Color() {Name = "Red", Code = "#ff0000"},
                        new Color() {Name = "Blue", Code = "#1000ff"}
                    };
                    context.AddRange(listColor);
                }

                if (!context.ProductCategories.Any())
                {
                    List<ProductCategory> listProductCategories = new List<ProductCategory>()
                    {
                        new ProductCategory()
                        {
                            Name = "Men shirt",
                            SeoAlias = "men-shirt",
                            Description = "This is Men shirt",
                            DateCreated = DateTime.Now,
                            Status = Status.Active,
                            SortOrder = 1,
                            Products = new List<Product>()
                            {
                                new Product()
                                {
                                    Name = "Product1",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-1"
                                },
                                new Product()
                                {
                                    Name = "Product2",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-2"
                                },
                                new Product()
                                {
                                    Name = "Product3",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-3"
                                },
                                new Product()
                                {
                                    Name = "Product4",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-4"
                                },
                                new Product()
                                {
                                    Name = "Product5",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-5"
                                },
                                new Product()
                                {
                                    Name = "Product6",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-6"
                                },
                                new Product()
                                {
                                    Name = "Product7",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-7"
                                },
                                new Product()
                                {
                                    Name = "Product8",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-8"
                                },
                                new Product()
                                {
                                    Name = "Product9",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-9"
                                },
                                new Product()
                                {
                                    Name = "Product10",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-10"
                                },
                            }
                        },
                        new ProductCategory()
                        {
                            Name = "Women shirt",
                            SeoAlias = "women-shirt",
                            Description = "This is Women shirt",
                            DateCreated = DateTime.Now,
                            Status = Status.Active,
                            SortOrder = 2,
                            Products = new List<Product>()
                            {
                                new Product()
                                {
                                    Name = "Product11",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-11"
                                },
                                new Product()
                                {
                                    Name = "Product12",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-12"
                                },
                                new Product()
                                {
                                    Name = "Product13",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-13"
                                },
                                new Product()
                                {
                                    Name = "Product14",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-14"
                                },
                                new Product()
                                {
                                    Name = "Product15",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-15"
                                },
                                new Product()
                                {
                                    Name = "Product16",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-16"
                                },
                                new Product()
                                {
                                    Name = "Product17",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-17"
                                },
                                new Product()
                                {
                                    Name = "Product18",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-18"
                                },
                                new Product()
                                {
                                    Name = "Product19",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-19"
                                },
                                new Product()
                                {
                                    Name = "Product20",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-20"
                                },
                            }
                        },
                        new ProductCategory()
                        {
                            Name = "Men shoes",
                            SeoAlias = "men-shoes",
                            Description = "This is Men shoes",
                            DateCreated = DateTime.Now,
                            Status = Status.Active,
                            SortOrder = 3,
                            Products = new List<Product>()
                            {
                                new Product()
                                {
                                    Name = "Product21",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-21"
                                },
                                new Product()
                                {
                                    Name = "Product22",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-22"
                                },
                                new Product()
                                {
                                    Name = "Product23",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-23"
                                },
                                new Product()
                                {
                                    Name = "Product24",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-24"
                                },
                                new Product()
                                {
                                    Name = "Product25",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-25"
                                },
                                new Product()
                                {
                                    Name = "Product26",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-26"
                                },
                                new Product()
                                {
                                    Name = "Product27",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-27"
                                },
                                new Product()
                                {
                                    Name = "Product28",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-28"
                                },
                                new Product()
                                {
                                    Name = "Product29",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-29"
                                },
                                new Product()
                                {
                                    Name = "Product30",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-30"
                                },
                            }
                        },
                        new ProductCategory()
                        {
                            Name = "Women shoes",
                            SeoAlias = "women-shoes",
                            Description = "This is Women shoes",
                            DateCreated = DateTime.Now,
                            Status = Status.Active,
                            SortOrder = 4,
                            Products = new List<Product>()
                            {
                                new Product()
                                {
                                    Name = "Product31",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-31"
                                },
                                new Product()
                                {
                                    Name = "Product32",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-32"
                                },
                                new Product()
                                {
                                    Name = "Product33",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-33"
                                },
                                new Product()
                                {
                                    Name = "Product34",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-34"
                                },
                                new Product()
                                {
                                    Name = "Product35",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-35"
                                },
                                new Product()
                                {
                                    Name = "Product36",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-36"
                                },
                                new Product()
                                {
                                    Name = "Product37",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-37"
                                },
                                new Product()
                                {
                                    Name = "Product38",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-38"
                                },
                                new Product()
                                {
                                    Name = "Product39",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-39"
                                },
                                new Product()
                                {
                                    Name = "Product40",
                                    DateCreated = DateTime.Now,
                                    Price = 1000,
                                    PromotionPrice = 500,
                                    OriginalPrice = 900,
                                    Status = Status.Active,
                                    SeoAlias = "san-pham-40"
                                },
                            }
                        }
                    };
                    context.AddRange(listProductCategories);
                }

                if (!context.ProductImages.Any())
                {
                    List<ProductImage> listProductImages = new List<ProductImage>()
                    {
                        new ProductImage() {Caption = "Product-1", Path = "C:/Image/product1.png", ProductId = 1},
                        new ProductImage() {Caption = "Product-1b", Path = "C:/Image/product1b.png", ProductId = 1},
                        new ProductImage() {Caption = "Product-2", Path = "C:/Image/product2.png", ProductId = 2},
                        new ProductImage() {Caption = "Product-2b", Path = "C:/Image/product2b.png", ProductId = 2},
                        new ProductImage() {Caption = "Product-3", Path = "C:/Image/product3.png", ProductId = 3},
                        new ProductImage() {Caption = "Product-4", Path = "C:/Image/product4.png", ProductId = 4},
                        new ProductImage() {Caption = "Product-5", Path = "C:/Image/product5.png", ProductId = 5},
                        new ProductImage() {Caption = "Product-6", Path = "C:/Image/product6.png", ProductId = 6},
                        new ProductImage() {Caption = "Product-7", Path = "C:/Image/product7.png", ProductId = 7},
                        new ProductImage() {Caption = "Product-8", Path = "C:/Image/product8.png", ProductId = 8},
                        new ProductImage() {Caption = "Product-9", Path = "C:/Image/product9.png", ProductId = 9},
                        new ProductImage() {Caption = "Product-10", Path = "C:/Image/product10.png", ProductId = 10},
                        new ProductImage() {Caption = "Product-11", Path = "C:/Image/product11.png", ProductId = 11},
                        new ProductImage() {Caption = "Product-12", Path = "C:/Image/product12.png", ProductId = 12},
                        new ProductImage() {Caption = "Product-13", Path = "C:/Image/product13.png", ProductId = 13},
                        new ProductImage() {Caption = "Product-14", Path = "C:/Image/product14.png", ProductId = 14},
                        new ProductImage() {Caption = "Product-15", Path = "C:/Image/product15.png", ProductId = 15},
                        new ProductImage() {Caption = "Product-16", Path = "C:/Image/product16.png", ProductId = 16},
                        new ProductImage() {Caption = "Product-17", Path = "C:/Image/product17.png", ProductId = 17},
                        new ProductImage() {Caption = "Product-18", Path = "C:/Image/product18.png", ProductId = 18},
                        new ProductImage() {Caption = "Product-19", Path = "C:/Image/product19.png", ProductId = 19},
                        new ProductImage() {Caption = "Product-20", Path = "C:/Image/product20.png", ProductId = 20},
                        new ProductImage() {Caption = "Product-21", Path = "C:/Image/product21.png", ProductId = 21},
                        new ProductImage() {Caption = "Product-22", Path = "C:/Image/product22.png", ProductId = 22},
                        new ProductImage() {Caption = "Product-23", Path = "C:/Image/product23.png", ProductId = 23},
                        new ProductImage() {Caption = "Product-24", Path = "C:/Image/product24.png", ProductId = 24},
                        new ProductImage() {Caption = "Product-25", Path = "C:/Image/product25.png", ProductId = 25},
                        new ProductImage() {Caption = "Product-26", Path = "C:/Image/product26.png", ProductId = 26},
                        new ProductImage() {Caption = "Product-27", Path = "C:/Image/product27.png", ProductId = 27},
                        new ProductImage() {Caption = "Product-28", Path = "C:/Image/product28.png", ProductId = 28},
                        new ProductImage() {Caption = "Product-29", Path = "C:/Image/product29.png", ProductId = 29},
                        new ProductImage() {Caption = "Product-30", Path = "C:/Image/product30.png", ProductId = 30},
                        new ProductImage() {Caption = "Product-31", Path = "C:/Image/product31.png", ProductId = 31},
                        new ProductImage() {Caption = "Product-32", Path = "C:/Image/product32.png", ProductId = 32},
                        new ProductImage() {Caption = "Product-33", Path = "C:/Image/product33.png", ProductId = 33},
                        new ProductImage() {Caption = "Product-34", Path = "C:/Image/product34.png", ProductId = 34},
                        new ProductImage() {Caption = "Product-35", Path = "C:/Image/product35.png", ProductId = 35},
                        new ProductImage() {Caption = "Product-36", Path = "C:/Image/product36.png", ProductId = 36},
                        new ProductImage() {Caption = "Product-37", Path = "C:/Image/product37.png", ProductId = 37},
                        new ProductImage() {Caption = "Product-38", Path = "C:/Image/product38.png", ProductId = 38},
                        new ProductImage() {Caption = "Product-39", Path = "C:/Image/product39.png", ProductId = 39},
                        new ProductImage() {Caption = "Product-40", Path = "C:/Image/product40.png", ProductId = 40},
                    };
                    context.ProductImages.AddRange(listProductImages);
                }

                if (!context.ProductQuantities.Any())
                {
                    List<ProductQuantity> listProductQuantities = new List<ProductQuantity>();
                    for (int i = 1; i <= 40; i++)
                    {
                        for (int j = 1; j <= 6; j++)
                        {
                            for (int k = 1; k <= 4; k++)
                            {
                                var productQuantity = new ProductQuantity()
                                {
                                    ColorId = k,
                                    Quantity = 1000,
                                    ProductId = i,
                                    SizeId = j
                                };
                                listProductQuantities.Add(productQuantity);
                            }
                        }
                    }

                    context.ProductQuantities.AddRange(listProductQuantities);
                }

                if (!context.Tags.Any())
                {
                    List<Tag> listTags = new List<Tag>();
                    for (int i = 1; i <= 40; i++)
                    {
                        var tag = new Tag() {Name = "product - " + i, Id = "product" + i};
                        listTags.Add(tag);
                    }

                    context.Tags.AddRange(listTags);
                }

                if (!context.ProductTags.Any())
                {
                    List<ProductTag> listProductTags = new List<ProductTag>();
                    for (int i = 1; i < 40; i++)
                    {
                        var productTag = new ProductTag() {ProductId = i, TagId = "product" + i};
                        listProductTags.Add(productTag);
                    }

                    context.ProductTags.AddRange(listProductTags);
                }
                context.SaveChanges();
                var query = from p in context.Products
                    join pc in context.ProductCategories on p.CategoryId equals pc.Id
                    join pq in context.ProductQuantities on p.Id equals pq.ProductId 
                    join s in context.Sizes on pq.SizeId equals s.Id
                    join c in context.Colors on pq.ColorId equals c.Id
                    join pt in context.ProductTags on p.Id equals pt.ProductId
                    join t in context.Tags on pt.TagId equals t.Id 
                    select new
                    {
                        CategoryName = pc.Name,
                        ProductName = p.Name,
                        ProductQuantity = pq.Quantity,
                        ProductSize = s.Name,
                        ProductColor = c.Name + " " + c.Code,
                        ProductTag = t.Name
                    };
                foreach (var tableResult in query)
                {
                    Console.WriteLine(tableResult.CategoryName + " " + tableResult.ProductName + " " +
                                      tableResult.ProductQuantity + " " +
                                      tableResult.ProductSize + " " + tableResult.ProductColor + " " +
                                      tableResult.ProductTag);
                }
            }
        }
    }
}