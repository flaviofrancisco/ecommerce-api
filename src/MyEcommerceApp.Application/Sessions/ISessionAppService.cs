using System.Threading.Tasks;
using Abp.Application.Services;
using MyEcommerceApp.Sessions.Dto;

namespace MyEcommerceApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
