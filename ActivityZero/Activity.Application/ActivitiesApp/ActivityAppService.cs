using Abp.Domain.Repositories;
using Activity.ActivitiesApp.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Activity.Entities;

namespace Activity.ActivitiesApp
{
    public class ActivityAppService : ActivityAppServiceBase, IActivityAppService
    {
        public IRepository<Activity.Entities.Activity, long> _activityRepository;

        public ActivityAppService(IRepository<Activity.Entities.Activity, long> activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public GetActivitiesOutput GetActivities(GetActivitiesInput input)
        {
            var query = _activityRepository.GetAll();
            query = query.Where(activity => activity.Id == input.ActivityId);

            return new GetActivitiesOutput { Activities = Mapper.Map<List<ActivityDto>>(query) };
        }
    }
}
