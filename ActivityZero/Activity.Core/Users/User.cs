using Abp.Authorization.Users;
using Activity.Entities;
using Activity.MultiTenancy;
using System.Collections;
using System.Collections.Generic;

namespace Activity.Users
{
    public class User : AbpUser<Tenant, User>
    {
        public ICollection<Discuss> Discusses { get; protected set; }
        public ICollection<Intention> Intentions { get; protected set; }

        public User()
        {
            Discusses = new HashSet<Discuss>();
            Intentions = new HashSet<Intention>();
        }
    }
}