using System.Threading.Tasks;
using Abp.Application.Services;
using MyEcommerceApp.Authorization.Accounts.Dto;

namespace MyEcommerceApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
