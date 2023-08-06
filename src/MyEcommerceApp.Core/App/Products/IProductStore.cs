using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public interface IProductStore: ITransientDependency
    {
        Task<Guid> CreateAsync(Product product);
    }
}
