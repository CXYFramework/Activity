using Abp.Application.Services;
using Activity.Activities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Activities
{
    public interface IActivityAppService : IApplicationService
    {
        GetActivitiesOutput GetActivities(GetActivitiesInput input);
    }
}
