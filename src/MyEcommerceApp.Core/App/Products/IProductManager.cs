using Abp.Dependency;
using MyEcommerceApp.App.Products.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public interface IProductManager: ITransientDependency
    {
        Task<ProductDto> CreateAsync(ProductDto input);
        Task<List<ProductDto>> GetAllAsync();
    }
}
