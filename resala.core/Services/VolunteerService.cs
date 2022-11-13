using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using resala.core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Services
{
    public class VolunteerService : IVolunteerService
    {
        public IBasicService<MemberVolunteer> BasicService { get; set; }



        public VolunteerService(IBasicService<MemberVolunteer> basicService)
        {
            BasicService = basicService;
        }

    }
}
