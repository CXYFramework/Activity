using Abp.Application.Services;
using Activity.ActivitiesApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.ActivitiesApp
{
    public interface IActivityAppService : IApplicationService
    {
        GetActivitiesOutput GetActivities(GetActivitiesInput input);
    }
}
