using Abp.ObjectMapping;
using MyEcommerceApp.App.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public class ProductManager: IProductManager
    {
        private readonly IProductStore _productStore;
        private readonly IObjectMapper _objectMapper;
        public ProductManager(
            IProductStore productStore,
            IObjectMapper objectMapper) 
        { 
            _objectMapper = objectMapper;
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

        public async Task<ProductDto> CreateAsync(ProductDto input)
        {
            if (!IsValid(input))
            {
                throw new Exception("Invalid product!");
            }

            if (input.Id == Guid.Empty)
            { 
                input.Id = Guid.NewGuid();
            }

            var product = _objectMapper.Map<Product>(input);


            if (product.Variants == null)
            {
                foreach (var variant in product.Variants)
                {
                    if (variant.Id == Guid.Empty)
                    {
                        variant.Id = Guid.NewGuid();
                    }

                    variant.ProductId = product.Id;
                }
            }

            var insertedProduct = await _productStore.CreateAsync(product);

            return _objectMapper.Map<ProductDto>(insertedProduct);

        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var productList = await _productStore.GetAllAsync();

            return _objectMapper.Map<List<ProductDto>>(productList);
        }

    }
}
