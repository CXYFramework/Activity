using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Activity.Users;

namespace Activity.Entities
{
    public class Activity: AuditedEntity<long>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual User Owner { get; set; }
        public virtual ActivityCatagory Catagory { get; set; }
        public virtual ICollection<ActivityItem> ActivityItems { get; protected set; }
        public virtual ICollection<Discuss> Discusses { get; protected set; }

        public Activity()
        {
            ActivityItems = new HashSet<ActivityItem>();
            Discusses = new HashSet<Discuss>();
        }
    }
}
