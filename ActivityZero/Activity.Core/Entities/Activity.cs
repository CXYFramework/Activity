using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Activity.Entities
{
    public class Activity: AuditedEntity<long>
    {
        public string Title { get; set; }
        public virtual ActivityCatagory Catagory { get; set; }
        public virtual ICollection<ActivityItem> ActivityItems { get; set; }
        public virtual ICollection<Discuss> Discusses { get; set; }

        public Activity()
        {
            ActivityItems = new HashSet<ActivityItem>();
            Discusses = new HashSet<Discuss>();
        }
    }
}
