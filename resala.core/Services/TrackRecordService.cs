using resala.core.Domain.Models;
using resala.core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Services
{
    public class TrackRecordService : ITrackRecordService
    {
        public IBasicService<TrackRecord> BasicService { get; set; }

        public TrackRecordService(IBasicService<TrackRecord> basicService)
        {
            BasicService = basicService;
        }


    }
}
