using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Products
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        [Key]
        [Column(Order = 1)]
        public Guid ProductId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CategoryId { get; set; }
    }
}
