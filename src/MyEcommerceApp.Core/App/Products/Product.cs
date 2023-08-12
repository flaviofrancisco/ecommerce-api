using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MyEcommerceApp.App.Products
{    
    public class Product: Entity<Guid>
    {        
        public string Name { get; set; }  
        
        public ICollection<ProductVariant> Variants { get; set; }
    }
}
