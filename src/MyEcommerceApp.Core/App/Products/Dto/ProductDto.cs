using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Ean { get; set; }
    }
}
