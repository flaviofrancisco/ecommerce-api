using Abp.AutoMapper;
using MyEcommerceApp.App.Products;

namespace MyEcommerceApp.App.v1.Products.Dto
{
    [AutoMapTo(typeof(Product))]
    public class CreateProductDto
    {

    }
}
