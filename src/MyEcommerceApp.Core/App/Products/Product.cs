using Abp.Authorization.Users;
using Abp.Domain.Entities;
using MyEcommerceApp.App.Categories;
using MyEcommerceApp.App.Commons;
using MyEcommerceApp.App.Taxes;
using MyEcommerceApp.App.Volumes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Products
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        [MaxLength(1000)]
        public string Name { get; set; }
        public ICollection<ProductVariant> Variants { get; set; }
        public decimal ValueAfterTax { get; set; }
        public decimal ValueBeforeTax { get; set; }
        /// <summary>
        /// the amount added to the cost price of goods to cover overheads and profit (%)
        /// </summary>
        public decimal Markup { get; set; }        
        public float VolumeValue { get; set; }
        public Guid? VolumeId { get; set; }

        [ForeignKey(nameof(VolumeId))]
        public virtual Volume Volume {get; set;}
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Tax> Taxes { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
