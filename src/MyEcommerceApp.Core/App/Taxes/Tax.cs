using MyEcommerceApp.App.Commons;
using MyEcommerceApp.App.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Taxes
{
    [Table("Taxes")]
    public class Tax: BaseEntity
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
