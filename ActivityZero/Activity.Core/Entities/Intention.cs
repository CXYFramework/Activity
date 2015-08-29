using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace Activity.Entities
{
    public class Intention: AuditedEntity<long>
    {
        public bool JoinConformation { get; set; }
    }
}
