using Abp.Domain.Entities;
using MyEcommerceApp.App.Commons;
using MyEcommerceApp.App.Sizes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Products
{
    [Table("ProductVariants")]
    public class ProductVariant: BaseEntity
    {
        public string Name { get; set; }
        [MaxLength(300), Required]
        public string Ean { get; set; }
        public string Description { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public ICollection<Size> Sizes { get; set; }
    }
}
