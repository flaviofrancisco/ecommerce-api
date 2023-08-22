using MyEcommerceApp.App.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Volumes
{
    [Table("Volumes")]
    public class Volume: BaseEntity
    {
        // Kg; g; liters ...
        public string Name { get; set; }        
    }
}
