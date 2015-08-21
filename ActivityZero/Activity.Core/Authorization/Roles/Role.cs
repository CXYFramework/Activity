using Abp.Authorization.Roles;
using Activity.MultiTenancy;
using Activity.Users;

namespace Activity.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}