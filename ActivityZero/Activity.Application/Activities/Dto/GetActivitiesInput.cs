using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Activities.Dto
{
    public class GetActivitiesInput : IInputDto
    {
        public int? ActivityId { get; set; }
    }
}
