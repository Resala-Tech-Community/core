using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using resala.core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Controllers
{
    [Route("/api/[controller]")]
    public class TrackerController : IBasicController<Tracker, TrackerResource, AddTrackerResource>
    {
        private readonly ITrackerServicies _trackerService;


        public TrackerController(ITrackerServicies trackerservice, IMapper mapper) : base(mapper, trackerservice.BasicService)
        {
            _trackerService = trackerservice;
        }


    }
}
