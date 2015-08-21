using Abp.MultiTenancy;
using Activity.Users;

namespace Activity.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}