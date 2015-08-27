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
        public DateTime StartTime { get; set; }
        public string Place { get; set; }
        public string DoWhat { get; set; }
        public int Budget { get; set; }
        public int SequenceNO { get; set; }

        public virtual Activity Activity { get; set;}
    }
}
