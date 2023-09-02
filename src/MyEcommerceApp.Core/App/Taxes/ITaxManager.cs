using Abp.Dependency;
using MyEcommerceApp.App.Taxes.Dto;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Taxes
{
    public interface ITaxManager: ITransientDependency
    {
        Task<TaxOutput> CreateAsync(CreateNewTaxInput input);
    }
}
