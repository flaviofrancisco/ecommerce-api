using MyEcommerceApp.App.Commons;
using MyEcommerceApp.App.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Categories
{
    [Table("Categories")]
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public Guid ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Category Parent { get; set; }
        public string Code { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
