using MyEcommerceApp.App.Products;
using MyEcommerceApp.App.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductManager _productManager;

        public ProductService(IProductManager productManager)
        { 
            _productManager = productManager;
        }

        public async Task<Guid> CreateAsync(ProductDto input)
        {
            return await _productManager.CreateAsync(input);
        }
    }
}
