using Abp.Application.Services.Dto;
using System;

namespace MyEcommerceApp.App.Products.Dto
{    
    public class ProductVariantDto: EntityDto<Guid>
    {
        public string Name { get; set; }                
        public string Ean { get; set; }
        public string Description { get; set; }

    }
}
