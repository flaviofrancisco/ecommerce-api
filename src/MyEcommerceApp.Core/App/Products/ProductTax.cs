using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Products
{
    [Table("ProductTaxes")]
    public class ProductTax
    {
        [Key]
        [Column(Order = 1)]
        public Guid ProductId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid TaxId { get; set; }
    }
}
