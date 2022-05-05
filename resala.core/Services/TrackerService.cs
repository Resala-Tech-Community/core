using resala.core.Domain.Models;
using resala.core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Services
{
    public class TrackerService : ITrackerServicies
    {
        public IBasicService<Tracker> BasicService { get; set; }

        public TrackerService(IBasicService<Tracker> basicService)
        {
            BasicService = basicService;
        }
    }
}
