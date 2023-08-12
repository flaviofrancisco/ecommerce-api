using Abp.Application.Services;
using MyEcommerceApp.App.Products.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Products
{
    public interface IProductService: IApplicationService
    {
        Task<ProductDto> CreateAsync(ProductDto input);

        Task<List<ProductDto>> GetAllAsync();
    }
}
