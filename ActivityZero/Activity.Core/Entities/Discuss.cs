using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Activity.Entities
{
    public class Discuss: AuditedEntity<long>
    {
        public virtual int SequenceNO { get; set; }
        public virtual string Content { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
