using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using resala.core.Extensions;
using resala.core.Resources;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace resala.core.Controllers
{
    [Route("/api/[controller]")]
    public class CommitteeController : IBasicController<Committee,CommitteeResource,AddCommitteeResource>
    {
        private readonly ICommitteeService _committeeService;


        public CommitteeController(ICommitteeService committeeService, IMapper mapper) : base(mapper,committeeService.BasicService)
        {
            _committeeService = committeeService;
        }

      

    }
}
