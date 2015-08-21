using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Activity.Authorization.Roles;
using Activity.Users;

namespace Activity.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(IRepository<Tenant> tenantRepository)
            : base(tenantRepository)
        {

        }
    }
}