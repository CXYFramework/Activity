using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Runtime.Session;
using Activity.MultiTenancy;
using Activity.Users;

namespace Activity
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ActivityAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ActivityAppServiceBase()
        {
            LocalizationSourceName = ActivityConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }
    }
}