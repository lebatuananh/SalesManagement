using AutoMapper;
using SalesManagement.ConsoleApp.Application.ViewModel;
using SalesManagement.ConsoleApp.Domain.Data.Entities;

namespace SalesManagement.ConsoleApp.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ColorViewModel, Color>().ConstructUsing(c => new Color());
            CreateMap<ProductViewModel, Product>().ConstructUsing(c => new Product(c.Name, c.CategoryId, c.Price,
                c.PromotionPrice, c.OriginalPrice, c.Description, c.Content, c.Tags, c.Unit, c.Status, c.SeoPageTitle,
                c.SeoAlias, c.SeoKeywords, c.SeoDescription));
            CreateMap<ProductCategoryViewModel, ProductCategory>().ConstructUsing(c =>
                new ProductCategory(c.Name, c.Description, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription,
                    c.SortOrder, c.Status));
            CreateMap<ProductImageViewModel, ProductImage>().ConstructUsing(c=>new ProductImage());
            CreateMap<ProductQuantityViewModel, ProductQuantity>().ConstructUsing(c=>new ProductQuantity());
            CreateMap<ProductTagViewModel,ProductTag>().ConstructUsing(c=>new ProductTag());
            CreateMap<SizeViewMode, Size>().ConstructUsing(c => new Size());
            CreateMap<TagViewModel, Tag>().ConstructUsing(c => new Tag());
            CreateMap<WholePriceViewModel, WholePrice>().ConstructUsing(c => new WholePrice());
        }
    }
}