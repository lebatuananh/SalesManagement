using System;
using System.Collections.Generic;
using SalesManagement.ConsoleApp.Application.ViewModel;
using SalesManagement.ConsoleApp.Infrastructure.Utilities.Dtos;

namespace SalesManagement.ConsoleApp.Application.Interfaces
{
    public interface IProductService:IDisposable
    {
        List<ProductViewModel> GetAll();
        
        ProductViewModel Add(ProductViewModel productViewModel);

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
        
        void Update(ProductViewModel productViewModel);
        
        void Delete(int id);
        
        ProductViewModel GetById(int id);
        
        void Save();
        
        void ImportExcel(string filePath, int categoryId);
        
        void AddQuantity(int productId, List<ProductQuantityViewModel>quantityViewModels);
        
        List<ProductViewModel> GetQuantities(int productId);
        
        void AddImages(int productId, string[] images);
        
        List<ProductImageViewModel> GetImages(int productId);
        
        void AddWholePrice(int productId, List<WholePriceViewModel> wholePriceViewModels);
        
        List<WholePriceViewModel> GetWholePrice(int productId);
        
        List<ProductViewModel> GetLastest(int top);
        
        List<ProductViewModel> GetHotProduct(int top);
        
        List<ProductViewModel> GetRelatedProducts(int id, int top);
        
        List<ProductViewModel> GetUpSellProducts(int top);
        
        List<TagViewModel> GetProductTags(int productId);
        
        bool CheckAvailability(int productId, int size, int color);
    }
}