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
    public class TrackRecordController : IBasicController<TrackRecord, TrackRecordResource, AddTrackRecordResource>
    {
        private readonly ITrackRecordService _trackRecordService;


        public TrackRecordController(ITrackRecordService trackRecordService, IMapper mapper) : base(mapper, trackRecordService.BasicService)
        {
            _trackRecordService = trackRecordService;
        }


    }
}
