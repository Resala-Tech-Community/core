using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using resala.core.Extensions;
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

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] AddVolunteerResources resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            Volunteer volunteer = _mapper.Map<AddVolunteerResources, Volunteer>(resource);

            ModelChangeResponse res = await _volunteerService.SaveAsync(volunteer);

            if (!res.Success)
                return BadRequest(res.Message);

            VolunteerResource volResource = _mapper.Map<Volunteer, VolunteerResource>(res.ChangedModel as Volunteer);

            return Ok(volResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] AddVolunteerResources resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            Volunteer vol = _mapper.Map<AddVolunteerResources, Volunteer>(resource);
            ModelChangeResponse result = await _volunteerService.UpdateAsync(id, vol);

            if (!result.Success)
                return BadRequest(result.Message);

            VolunteerResource volRes = _mapper.Map<Volunteer, VolunteerResource>(result.ChangedModel as Volunteer);

            return Ok(volRes);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            ModelChangeResponse result = await _volunteerService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var volRes = _mapper.Map<Volunteer, VolunteerResource>(result.ChangedModel as Volunteer);

            return Ok(volRes);
        }
    }
}
