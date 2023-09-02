using Abp.Domain.Entities;
using MyEcommerceApp.App.Commons;
using MyEcommerceApp.App.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Taxes
{
    [Table("Taxes")]
    public class Tax: BaseEntity, ISoftDelete
    {
        [Required]
        [MaxLength(10)] 
        public string Acronym { get; set; }
        
        [Required]
        [MaxLength(300)]
        public string Name { get; set; } 
        
        public decimal Rate { get; set; } = 0.0m;
        public virtual ICollection<Product> Products { get; set; }
    }
}
