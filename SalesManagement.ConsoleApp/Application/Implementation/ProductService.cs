using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using SalesManagement.ConsoleApp.Application.Interfaces;
using SalesManagement.ConsoleApp.Application.ViewModel;
using SalesManagement.ConsoleApp.Domain.Data.Entities;
using SalesManagement.ConsoleApp.Domain.Data.Enum;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.Interfaces;
using SalesManagement.ConsoleApp.Infrastructure.Utilities.Dtos;
using SalesManagement.ConsoleApp.Infrastructure.Utilities.Helpers;

namespace SalesManagement.ConsoleApp.Application.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product, int> _productRepository;
        private readonly IRepository<Tag, string> _tagRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IRepository<Product, int> productRepository, IRepository<Tag, string> tagRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _tagRepository = tagRepository;
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x => x.ProductCategory).ProjectTo<ProductViewModel>().ToList();
        }

        public ProductViewModel Add(ProductViewModel productViewModel)
        {
            var listProductTags = new List<ProductTag>();
            if (!string.IsNullOrEmpty(productViewModel.Tags))
            {
                string[] tags = productViewModel.Tags.Split(",");
                foreach (var t in tags)
                {
                    var tagId = TextHelpers.ToUnString(t);
                    if (!_tagRepository.FindAll(x => x.Id == tagId).Any())
                    {
                        Tag tag = new Tag()
                        {
                            Id = tagId,
                            Name = t
                        };
                        _tagRepository.Add(tag);
                    }

                    ProductTag productTag = new ProductTag()
                    {
                        TagId = tagId
                    };
                    listProductTags.Add(productTag);
                }

                var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
                foreach (var productTag in listProductTags)
                {
                    product.ProductTags.Add(productTag);
                }

                _productRepository.Add(product);
            }

            return productViewModel;
        }

        public PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            var query = _productRepository.FindAll(x => x.Status == Status.Active);
            if (!String.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            if (categoryId.HasValue)
                query = query.Where(x => x.CategoryId == categoryId.Value);
            int totalRow = query.Count();
            query = query.OrderBy(x => x.Name).Skip((page - 1) * pageSize).Take(pageSize);
            var data = query.ProjectTo<ProductViewModel>().ToList();
            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }

        public void Update(ProductViewModel productViewModel)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProductViewModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void ImportExcel(string filePath, int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public void AddQuantity(int productId, List<ProductQuantityViewModel> quantityViewModels)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductViewModel> GetQuantities(int productId)
        {
            throw new System.NotImplementedException();
        }

        public void AddImages(int productId, string[] images)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductImageViewModel> GetImages(int productId)
        {
            throw new System.NotImplementedException();
        }

        public void AddWholePrice(int productId, List<WholePriceViewModel> wholePriceViewModels)
        {
            throw new System.NotImplementedException();
        }

        public List<WholePriceViewModel> GetWholePrice(int productId)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductViewModel> GetLastest(int top)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductViewModel> GetHotProduct(int top)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductViewModel> GetRelatedProducts(int id, int top)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductViewModel> GetUpSellProducts(int top)
        {
            throw new System.NotImplementedException();
        }

        public List<TagViewModel> GetProductTags(int productId)
        {
            throw new System.NotImplementedException();
        }

        public bool CheckAvailability(int productId, int size, int color)
        {
            throw new System.NotImplementedException();
        }
    }
}