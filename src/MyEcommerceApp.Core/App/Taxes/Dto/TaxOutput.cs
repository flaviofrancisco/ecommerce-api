
namespace MyEcommerceApp.App.Taxes.Dto
{
    public class TaxOutput
    {
        public string Name { get; set; }        
        public string Acronym { get; set; }
        public decimal Rate { get; set; } = 0.0m;
    }
}
