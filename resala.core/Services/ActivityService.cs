using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;

namespace resala.core.Services
{
    public class ActivityService : IActivityServices
    {
        public IBasicService<Activity> BasicService { get; set; }

        public ActivityService(IBasicService<Activity> basicService)
        {
            BasicService = basicService;
        }



        // for any extenstoins related to activity services

    }
}
