using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Activity.Entities
{
    public class ActivityItem: AuditedEntity<long>
    {
        public virtual DateTime StartTime { get; set; }
        public virtual string Place { get; set; }
        public virtual string DoWhat { get; set; }
        public virtual int Budget { get; set; }
        public virtual int SequenceNO { get; set; }

        public virtual Activity Activity { get; set;}
    }
}
