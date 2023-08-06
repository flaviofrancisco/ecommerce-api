using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public class ProductStore : IProductStore
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductStore(IRepository<Product, Guid> productRepository)
        { 
            _productRepository = productRepository;
        }

        public async Task<Guid> CreateAsync(Product product)
        {
            var insertedProduct = await _productRepository.InsertAsync(product);

            return insertedProduct.Id;
        }
    }
}
