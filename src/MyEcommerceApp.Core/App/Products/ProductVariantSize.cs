using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Products
{
    [Table("ProductVariantSizes")]
    public class ProductVariantSize
    {
        [Key]
        [Column(Order = 1)]
        public Guid ProductVariantId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SizeId { get; set; }
    }
}
