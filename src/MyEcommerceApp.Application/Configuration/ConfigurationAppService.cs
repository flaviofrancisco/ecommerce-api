using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyEcommerceApp.Configuration.Dto;

namespace MyEcommerceApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyEcommerceAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
