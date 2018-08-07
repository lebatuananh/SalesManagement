using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.WebEncoders.Testing;
using SalesManagement.ConsoleApp.Application.AutoMapper;
using SalesManagement.ConsoleApp.Application.Implementation;
using SalesManagement.ConsoleApp.Application.Interfaces;
using SalesManagement.ConsoleApp.Application.ViewModel;
using SalesManagement.ConsoleApp.Domain.Data.EF;
using SalesManagement.ConsoleApp.Domain.Data.Entities;
using SalesManagement.ConsoleApp.Domain.Data.Enum;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.Interfaces;
using SalesManagement.ConsoleApp.Infrastructure.Utilities.Helpers;

namespace SalesManagement.ConsoleApp
{
    public static class Program
    {
        // ReSharper disable once TooManyDeclarations
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var context = new AppDbContext())
            {
                //                DbInitializer dbInitializer = new DbInitializer(context);
                //                dbInitializer.Seed().Wait();
                //var query = from p in context.Products
                //    join pc in context.ProductCategories on p.CategoryId equals pc.Id
                //    join pq in context.ProductQuantities on p.Id equals pq.ProductId
                //    join s in context.Sizes on pq.SizeId equals s.Id
                //    join c in context.Colors on pq.ColorId equals c.Id
                //    join pt in context.ProductTags on p.Id equals pt.ProductId
                //    join t in context.Tags on pt.TagId equals t.Id
                //    select new
                //    {
                //        CategoryName = pc.Name,
                //        ProductName = p.Name,
                //        ProductQuantity = pq.Quantity,
                //        ProductSize = s.Name,
                //        ProductColor = c.Name + " " + c.Code,
                //        ProductTag = t.Name
                //    };
                //foreach (var tableResult in query)
                //{
                //    Console.WriteLine(tableResult.CategoryName + " " + tableResult.ProductName + " " +
                //                      tableResult.ProductQuantity + " " +
                //                      tableResult.ProductSize + " " + tableResult.ProductColor + " " +
                //                      tableResult.ProductTag);
                //}
                Mapper.Initialize(cfg =>
                {
                    cfg.AddProfile<DomainToViewModelMappingProfile>();
                    cfg.AddProfile<ViewModelToDomainMappingProfile>();
                });
                IRepository<Product, int> productRepository = new EFRepository<Product, int>(context);
                IRepository<Tag, string> tagRepository = new EFRepository<Tag, string>(context);
                IRepository<ProductTag, int> productTagRepository = new EFRepository<ProductTag, int>(context);
                IRepository<ProductQuantity, int> productquantityRepository = new EFRepository<ProductQuantity, int>(context);
                IRepository<ProductImage, int> productImageRepository = new EFRepository<ProductImage, int>(context);
                IRepository<WholePrice,int>wholePriceRepository = new EFRepository<WholePrice, int>(context);
                IUnitOfWork unitOfWork = new EFUnitOfWork(context);
                IProductService productService = new ProductService(productRepository, tagRepository, unitOfWork, productTagRepository, productquantityRepository, productImageRepository,wholePriceRepository);
                //                //var productViewModel = productService.GetAll();
                //                var productViewModel = productService.GetAllPaging(1, "Product", 1, 5);
                //                foreach (var item in productViewModel.Results.OrderBy(x=>x.Name))
                //                {
                //                    Console.WriteLine(item.Name);
                //                }

                //                foreach (var item in context.ProductCategories)
                //                {
                //                    Console.WriteLine(item.Name);
                //                    foreach (var itemProduct in context.Products.Where(x=>x.CategoryId==item.Id).OrderBy(y=>y.Name))
                //                    {
                //                        Console.WriteLine(itemProduct.Name);
                //                    }
                //                    Console.WriteLine("==================================");
                //                }
                //var newProductViewModel =productService.Add(new ProductViewModel()
                //{
                //    CategoryId = 4,
                //    Content = "This is product 42",
                //    DateCreated = DateTime.Now,
                //    Description = "This is product 42",
                //    OriginalPrice = 800,
                //    Name = "product 42",
                //    Status = Status.Active,
                //    PromotionPrice = 850,
                //    Unit = "set",
                //    Tags = "product42a,product42b,product41c",
                //    Price = 1000,
                //});
                //Console.WriteLine(newProductViewModel.Name);
                //productService.Save();

                //ProductViewModel updateProductViewModel=new ProductViewModel()
                //{
                //    Id = 42,
                //    CategoryId = 3,
                //    Content = "This is product 42",
                //    DateCreated = DateTime.Now,
                //    Description = "This is product 42",
                //    OriginalPrice = 800,
                //    Name = "product 42",
                //    Status = Status.Active,
                //    PromotionPrice = 850,
                //    Unit = "set",
                //    Tags = "product 42a,product 42b,product 42c",
                //    Price = 1000
                //};
                // productService.Update(updateProductViewModel);
                // productService.Save();
                //Console.WriteLine(productService.GetById(21).Name);
                //List<ProductQuantityViewModel>quantityViewModels=new List<ProductQuantityViewModel>()
                //{
                //    new ProductQuantityViewModel(){ColorId = 1,Quantity = 10,SizeId = 1},
                //    new ProductQuantityViewModel(){ColorId = 2,Quantity = 10,SizeId = 2},
                //    new ProductQuantityViewModel(){ColorId = 3,Quantity = 10,SizeId = 3}
                //};
                //productService.AddQuantity(42,quantityViewModels);

                //foreach (var productQuantity in productService.GetQuantities(40))
                //{
                //    Console.WriteLine(productQuantity.Product.Name +" "+productQuantity.Size.Name+" "+productQuantity.Color.Name);
                //}
                //string[] images = { "/ client - side / images / product / product - 42a.jpg",
                //    "/ client - side / images / product / product - 42b.jpg",
                //    "/ client - side / images / product / product - 42c.jpg" };
                //productService.AddImages(42,images,"This is image product 42");
                //Console.WriteLine("Done");
                //productService.Save();
                
                //foreach (var productImage in productService.GetImages(42))
                //{
                //    Console.WriteLine(productImage.Path+"======="+productImage.Caption);
                //}
                //List<WholePriceViewModel>wholePriceViewModels=new List<WholePriceViewModel>()
                //{
                //    new WholePriceViewModel(){ProductId = 42,FromQuantity = 10,ToQuantity = 100,Price = 600},
                //    new WholePriceViewModel(){ProductId = 42,FromQuantity = 101,ToQuantity = 1000,Price = 580},
                //};
                //productService.AddWholePrice(42,wholePriceViewModels);
                //Console.WriteLine("Done");
                //productService.Save();
                //foreach (var quantityProduct in productService.GetWholePrice(42))
                //{
                //    Console.WriteLine(quantityProduct.Product.Name+" "+quantityProduct.Price);
                //}
                foreach (var productLastest in productService.GetLastest(5))
                {
                    Console.WriteLine(productLastest.Name+" - "+productLastest.DateCreated);
                    Console.WriteLine(DateTime.Now);
                }
                Console.ReadKey();

            }


            //            List<Product> listProducts = new List<Product>();
            //            for (int i = 1; i <= 4; i++)
            //            {
            //                for (int j = 1; j <= 10; j++)
            //                {
            //                    var product = new Product()
            //                    {
            //                        CategoryId = i,
            //                        Content = "This is product " + (((i-1)*10)+j),
            //                        DateCreated = DateTime.Now,
            //                        Description = "This is product " + (((i-1)*10)+j),
            //                        OriginalPrice = 500,
            //                        PromotionPrice = 900,
            //                        Price = 1000,
            //                        Name = "Product " + (((i-1)*10)+j),
            //                        Status = Status.Active,
            //                        Unit = "set"
            //                    };
            //                    listProducts.Add(product);
            //                }
            //            }
            //
            //            foreach (var list in listProducts)
            //            {
            //                Console.WriteLine(list.Name);
            //            }
            //            Console.WriteLine(TextHelpers.ToUnString("?"));
            //            Console.WriteLine(TextHelpers.ToString(-1000000000));
            //            string s = "product 1";
            //            Console.WriteLine(s.Trim());
            //            Dictionary<string,string>dictionary=new Dictionary<string, string>();
            //            dictionary.Add("a","d");
            //            Console.WriteLine(TextHelpers.Parse("aac",dictionary));
        }
    }
}