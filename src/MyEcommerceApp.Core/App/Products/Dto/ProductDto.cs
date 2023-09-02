using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;

namespace MyEcommerceApp.App.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto: EntityDto<Guid>
    {
        public string Name { get; set; }

        public ICollection<ProductVariantDto> Variants { get; set; }
    }
}
