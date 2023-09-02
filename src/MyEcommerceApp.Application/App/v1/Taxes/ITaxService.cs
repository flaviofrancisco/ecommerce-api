using Abp.Application.Services.Dto;
using Abp.Dependency;
using MyEcommerceApp.App.Products.Dto;
using MyEcommerceApp.App.v1.Taxes.Dto;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Taxes
{
    public interface ITaxService: ITransientDependency
    {
        Task<TaxDto> CreateAsync(CreateTaxDto input);
        Task<TaxDto> GetAsync(GetTaxDto input);
        Task<TaxDto> UpdateAsync(UpdateTaxDto input);
        Task DeleteAsync(DeleteTaxDto input);
        Task<PagedResultDto<TaxDto>> GetAllAsync(PagedTaxResultRequestDto input);
        
    }
}
