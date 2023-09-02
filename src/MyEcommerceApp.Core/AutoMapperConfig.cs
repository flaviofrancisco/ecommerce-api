using AutoMapper;
using MyEcommerceApp.App.Products;
using MyEcommerceApp.App.Products.Dto;
using MyEcommerceApp.App.Taxes;
using MyEcommerceApp.App.Taxes.Dto;

namespace MyEcommerceApp
{
    public static class AutoMapperConfig
    {
        public static void ConfingMapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<Product, ProductDto>().ReverseMap();
            config.CreateMap<ProductVariant, ProductVariantDto>().ReverseMap();
            config.CreateMap<CreateNewTaxInput, Tax>();
            config.CreateMap<Tax, TaxOutput>();
        }
    }
}
