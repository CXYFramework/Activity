using Abp.Authorization.Users;
using Activity.MultiTenancy;

namespace Activity.Users
{
    public class User : AbpUser<Tenant, User>
    {

    }
}