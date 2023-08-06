using Abp.Dependency;
using MyEcommerceApp.App.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public interface IProductManager: ITransientDependency
    {
        Task<Guid> CreateAsync(ProductDto input);
    }
}
