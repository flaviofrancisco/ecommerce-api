using Abp.Application.Services;
using MyEcommerceApp.App.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public class ProductManager: IProductManager
    {
        private readonly IProductStore _productStore;
        public ProductManager(IProductStore productStore) 
        { 
            _productStore = productStore;
        }

        private bool IsValid(ProductDto input)
        { 
            if (input == null)
            {
                throw new ArgumentNullException("Product is empty");
            }

            if (string.IsNullOrEmpty(input?.Name)) {
                throw new ArgumentNullException("Product name is required");                
            }

            return true;
        }

        public async Task<Guid> CreateAsync(ProductDto input)
        {
            if (!IsValid(input))
            {
                throw new Exception("Invalid product!");
            }

            var product = new Product 
            { 
                Name = input.Name,
                Ean = input.Ean,
                Id = input.Id,
            };

            var insertedProduct = await _productStore.CreateAsync(product);

            return insertedProduct;

        }
    }
}
