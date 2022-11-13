using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using resala.core.Resources;

namespace resala.core.Controllers
{
    [Route("/api/[controller]")]
    public class VolunteersController : IBasicController<MemberVolunteer, ResponsibleVolunteerResource, AddResponsibleVolunteerResource>
    {
        private readonly IVolunteerService _volunteerService;


        public VolunteersController(IVolunteerService volunteerService, IMapper mapper) : base(mapper, volunteerService.BasicService)
        {
            _volunteerService = volunteerService;
        }
    }
}
