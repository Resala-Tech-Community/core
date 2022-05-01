using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace resala.core.Services
{
    public class CommitteeService : ICommitteeService
    {
        public IBasicService<Committee> BasicService { get; set; }


        public CommitteeService(IBasicService<Committee> basicService)
        {
            BasicService = basicService;
        }

    }
}
