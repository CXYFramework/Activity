using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Activity.Entities
{
    public class Menu : AuditedEntity
    {
        [Required]
        public string Text { get; set; }
        public int Parent { get; set; }
    }
}
