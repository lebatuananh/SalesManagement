using System;
using System.Collections.Generic;
using SalesManagement.ConsoleApp.Domain.Data.Entities;
using SalesManagement.ConsoleApp.Domain.Data.Enum;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagement.ConsoleApp.Domain.Data.EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _appDbContext;

        public DbInitializer(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Seed()
        {
            if (!this._appDbContext.Sizes.Any())
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
                this._appDbContext.Sizes.AddRange(listSizes);
            }

            if (!this._appDbContext.Colors.Any())
            {
                List<Color> listColor = new List<Color>()
                {
                    new Color() {Name = "Black", Code = "#000000"},
                    new Color() {Name = "White", Code = "#FFFFFF"},
                    new Color() {Name = "Red", Code = "#ff0000"},
                    new Color() {Name = "Blue", Code = "#1000ff"}
                };
                this._appDbContext.Colors.AddRange(listColor);
            }

            if (!this._appDbContext.ProductCategories.Any())
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
                        SortOrder = 1
                    },
                    new ProductCategory()
                    {
                        Name = "Women shirt",
                        SeoAlias = "women-shirt",
                        Description = "This is Women shirt",
                        DateCreated = DateTime.Now,
                        Status = Status.Active,
                        SortOrder = 2
                    },
                    new ProductCategory()
                    {
                        Name = "Men shoes",
                        SeoAlias = "men-shoes",
                        Description = "This is Men shoes",
                        DateCreated = DateTime.Now,
                        Status = Status.Active,
                        SortOrder = 3
                    },
                    new ProductCategory()
                    {
                        Name = "Women shoes",
                        SeoAlias = "women-shoes",
                        Description = "This is Women shoes",
                        DateCreated = DateTime.Now,
                        Status = Status.Active,
                        SortOrder = 4
                    }
                };
                this._appDbContext.ProductCategories.AddRange(listProductCategories);
            }

            if (!this._appDbContext.Products.Any())
            {

                List<Product>listProducts=new List<Product>();
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        var product = new Product()
                        {
                            CategoryId = i,
                            Content = "This is product " + (((i-1)*10)+j),
                            DateCreated = DateTime.Now,
                            Description = "This is product " + (((i-1)*10)+j),
                            OriginalPrice = 500,
                            PromotionPrice = 900,
                            Price = 1000,
                            Name = "Product " + (((i-1)*10)+j),
                            Status = Status.Active,
                            Unit = "set"
                        };
                        listProducts.Add(product);
                    }
                }
                this._appDbContext.Products.AddRange(listProducts);
            }

            if (!_appDbContext.ProductImages.Any())
            {
                string[] listCodes = new string[] {"a", "b", "c"};
                List<ProductImage> listProductImages = new List<ProductImage>();
                for (int i = 1; i <= 40; i++)
                {
                    foreach (var list in listCodes)
                    {
                        var productImage = new ProductImage()
                        {
                            Caption = "Product " + i + list,
                            Path = "/client-side/images/product/product-" + i + list + ".jpg",
                            ProductId = i
                        };
                        listProductImages.Add(productImage);
                    }
                }

                _appDbContext.ProductImages.AddRange(listProductImages);
            }

            if (!_appDbContext.ProductQuantities.Any())
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

                _appDbContext.ProductQuantities.AddRange(listProductQuantities);
            }

            if (!_appDbContext.Tags.Any())
            {
                List<Tag> listTags = new List<Tag>();
                for (int i = 1; i <= 40; i++)
                {
                    var tag = new Tag() {Name = "product - " + i, Id = "product" + i};
                    listTags.Add(tag);
                }

                _appDbContext.Tags.AddRange(listTags);
            }

            if (!_appDbContext.ProductTags.Any())
            {
                List<ProductTag> listProductTags = new List<ProductTag>();
                for (int i = 1; i <= 40; i++)
                {
                    var productTag = new ProductTag() {ProductId = i, TagId = "product" + i};
                    listProductTags.Add(productTag);
                }

                _appDbContext.ProductTags.AddRange(listProductTags);
            }

            await this._appDbContext.SaveChangesAsync();
        }
    }
}