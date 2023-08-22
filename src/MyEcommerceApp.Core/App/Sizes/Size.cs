using MyEcommerceApp.App.Commons;
using MyEcommerceApp.App.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Sizes
{
    [Table("Sizes")]
    public class Size: BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
