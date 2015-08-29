using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Activity.Entities;

namespace Activity.Activity.Dto
{
    public class ActivityDto:EntityDto
    {
        public string Title { get; set; }
        public virtual Users.User Owner { get; set; }
        public virtual ActivityCatagory Catagory { get; set; }
        public virtual ICollection<ActivityItem> ActivityItems { get; set; }
        public virtual ICollection<Discuss> Discusses { get; set; }
    }
}
