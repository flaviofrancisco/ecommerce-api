using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyEcommerceApp.Controllers
{
    public abstract class MyEcommerceAppControllerBase: AbpController
    {
        protected MyEcommerceAppControllerBase()
        {
            LocalizationSourceName = MyEcommerceAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
