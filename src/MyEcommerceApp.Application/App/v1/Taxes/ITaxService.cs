using Abp.Application.Services;
using MyEcommerceApp.App.Taxes.Dto;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Taxes
{
    public interface ITaxService: IApplicationService
    {
        Task<TaxOutput> CreateAsync(CreateNewTaxInput input);
    }
}
