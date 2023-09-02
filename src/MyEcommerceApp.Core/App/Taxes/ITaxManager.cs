using Abp.Application.Services.Dto;
using Abp.Dependency;
using MyEcommerceApp.App.Taxes.Dto;
using System;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Taxes
{
    public interface ITaxManager: ITransientDependency
    {
        Task<Tax> CreateAsync(Tax input);
        Task<Tax> GetAsync(Guid id);
        Task<Tax> UpdateAsync(Tax input);
        Task DeleteAsync(Tax input);
        Task<PagedResultDto<Tax>> GetAllAsync(PagedTaxResultRequestInput input, int? tenantId);
    }
}
