using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Products
{
    public class ProductVariant: Entity<Guid>
    {
        public string Name { get; set; }
        [MaxLength(300), Required]
        public string Ean { get; set; }
        public string Description { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
