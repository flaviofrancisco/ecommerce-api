using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public class ProductStore : IProductStore
    {
        private readonly IRepository<Product, Guid> _productRepository;
        private readonly IRepository<ProductVariant, Guid> _productVariantRepository;
        public ProductStore(
            IRepository<Product, Guid> productRepository,
            IRepository<ProductVariant, Guid> productVariantRepository)
        { 
            _productRepository = productRepository;
            _productVariantRepository = productVariantRepository;
        }
                
        public async Task<Product> CreateAsync(Product product)
        {
            _ = await _productRepository.InsertAsync(product);

            return product;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllListAsync();
        }
    }
}
