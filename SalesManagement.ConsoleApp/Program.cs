using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SalesManagement.ConsoleApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
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
                Mapper.Initialize(cfg => cfg.AddProfile<DomainToViewModelMappingProfile>());
                IRepository<Product, int> productRepository = new EFRepository<Product, int>(context);
                IProductService productService = new ProductService(productRepository);
                //var productViewModel = productService.GetAll();
                var productViewModel = productService.GetAllPaging(1, "Product", 1, 5);
                foreach (var item in productViewModel.Results.OrderBy(x=>x.Name))
                {
                    Console.WriteLine(item.Name);
                }
                
//                foreach (var item in context.ProductCategories)
//                {
//                    Console.WriteLine(item.Name);
//                    foreach (var itemProduct in context.Products.Where(x=>x.CategoryId==item.Id).OrderBy(y=>y.Name))
//                    {
//                        Console.WriteLine(itemProduct.Name);
//                    }
//                    Console.WriteLine("==================================");
//                }
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
        }
    }
}