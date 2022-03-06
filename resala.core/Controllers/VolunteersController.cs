using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Controllers
{
    [Route("/api/[controller]")]
    public class VolunteersController : Controller
    {
        private readonly IVolunteerService _volunteerService;


        public VolunteersController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        [HttpGet]
        public async Task<IEnumerable<Volunteer>> GetAllAsync()
        {
            return await _volunteerService.ListAsync();
        }
    }
}
