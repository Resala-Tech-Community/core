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
    public class VolunteersController : BaseController
    {
        private readonly IVolunteerService _volunteerService;


        public VolunteersController(IVolunteerService volunteerService, IMapper _mapper): base(_mapper)
        {
            _volunteerService = volunteerService;
        }

        [HttpGet]
        public async Task<IEnumerable<VolunteerResource>> GetAllAsync()
        {
            IEnumerable<Volunteer> volunteers = await _volunteerService.ListAsync();
            return _mapper.Map<IEnumerable<Volunteer>, IEnumerable<VolunteerResource>>(volunteers);
        }
    }
}
