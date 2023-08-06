using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Products
{
    public class Product: Entity<Guid>
    {
        public string Name { get; set; }

        [MaxLength(300), Required]
        public string Ean { get; set; }
    }
}
