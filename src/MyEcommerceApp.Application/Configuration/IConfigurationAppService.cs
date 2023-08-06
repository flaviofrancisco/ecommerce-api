using System.Threading.Tasks;
using MyEcommerceApp.Configuration.Dto;

namespace MyEcommerceApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
