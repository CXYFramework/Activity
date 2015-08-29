using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.ActivitiesApp.Dto
{
    public class ActivityDto : EntityDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int? OwnerId { get; set; }
    }
}
