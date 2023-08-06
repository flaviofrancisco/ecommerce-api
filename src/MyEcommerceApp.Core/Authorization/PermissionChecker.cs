using Abp.Authorization;
using MyEcommerceApp.Authorization.Roles;
using MyEcommerceApp.Authorization.Users;

namespace MyEcommerceApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
