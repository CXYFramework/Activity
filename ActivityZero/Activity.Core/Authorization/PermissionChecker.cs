using Abp.Authorization;
using Activity.Authorization.Roles;
using Activity.MultiTenancy;
using Activity.Users;

namespace Activity.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
