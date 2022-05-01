using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using resala.core.Resources;

namespace resala.core.Controllers
{
    [Route("/api/[controller]")]
    public class ActivityController : IBasicController<Activity,ActivityResource,AddActivityResource>
    {
        private readonly IActivityServices _activityService;


        public ActivityController(IActivityServices activitySevice, IMapper mapper) : base(mapper, activitySevice.BasicService)
        {
            _activityService = activitySevice;
        }

       
    }
}
