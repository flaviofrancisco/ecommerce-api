using Abp.Application.Services;
using MyEcommerceApp.App.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Products
{
    public interface IProductService: IApplicationService
    {
        Task<Guid> CreateAsync(ProductDto input);
    }
}
