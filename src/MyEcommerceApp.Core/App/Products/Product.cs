using Abp.Authorization.Users;
using Abp.Domain.Entities;
using MyEcommerceApp.App.Categories;
using MyEcommerceApp.App.Commons;
using MyEcommerceApp.App.Taxes;
using MyEcommerceApp.App.Volumes;
using MyEcommerceApp.Authorization.Users;
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
        public decimal ValueBeforeTax { get; set; }
        public float VolumeValue { get; set; }
        public Guid? VolumeId { get; set; }

        [ForeignKey(nameof(VolumeId))]
        public virtual Volume Volume {get; set;}
        public ICollection<Category> Categories { get; set; }
        public ICollection<Tax> Taxes { get; set; }

    }
}
