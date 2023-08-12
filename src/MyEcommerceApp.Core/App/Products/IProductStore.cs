using Abp.Dependency;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public interface IProductStore: ITransientDependency
    {
        Task<Product> CreateAsync(Product product);

        Task<List<Product>> GetAllAsync();
    }
}
