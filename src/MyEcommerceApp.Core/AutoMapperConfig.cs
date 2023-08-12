using AutoMapper;
using MyEcommerceApp.App.Products;
using MyEcommerceApp.App.Products.Dto;

namespace MyEcommerceApp
{
    public static class AutoMapperConfig
    {
        public static void ConfingMapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<Product, ProductDto>().ReverseMap();
            config.CreateMap<ProductVariant, ProductVariantDto>().ReverseMap();
        }
    }
}
