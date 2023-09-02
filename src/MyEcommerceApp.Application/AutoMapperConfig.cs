using Abp.Application.Services.Dto;
using AutoMapper;
using MyEcommerceApp.App.Taxes;
using MyEcommerceApp.App.Taxes.Dto;
using MyEcommerceApp.App.v1.Taxes.Dto;
using System.Collections.Generic;

namespace MyEcommerceApp
{
    public static class AutoMapperConfig
    {
        public static void ConfingMapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<Tax, TaxDto>().ReverseMap();  
            config.CreateMap<GetTaxDto,Tax>();
            config.CreateMap<DeleteTaxDto, Tax>();
            config.CreateMap<PagedTaxResultRequestDto, PagedTaxResultRequestInput>();
        }
    }
}
