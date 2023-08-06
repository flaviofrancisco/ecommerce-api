using Abp.Application.Services;
using MyEcommerceApp.MultiTenancy.Dto;

namespace MyEcommerceApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

