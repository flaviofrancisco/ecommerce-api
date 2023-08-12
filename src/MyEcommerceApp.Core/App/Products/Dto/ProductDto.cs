using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;

namespace MyEcommerceApp.App.Products.Dto
{    
    public class ProductDto: EntityDto<Guid>
    {
        public string Name { get; set; }

        public ICollection<ProductVariantDto> Variants { get; set; }
    }
}
