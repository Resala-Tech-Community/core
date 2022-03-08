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
    public class BranchesController : BaseController
    {
        private readonly IBranchService _branchService;


        public BranchesController(IBranchService branchService , IMapper mapper) : base(mapper)
        {
            _branchService = branchService;
        }

        [HttpGet]
        public async Task<IEnumerable<BranchResource>> GetAllAsync()
        {
            IEnumerable<Branch> Branches =  await _branchService.ListAsync();
            return _mapper.Map<IEnumerable<Branch>, IEnumerable<BranchResource>>(Branches);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] AddBranchResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            Branch branch = _mapper.Map<AddBranchResource,Branch>(resource);

            SaveResponse res = await _branchService.SaveAsync(branch);

            if (!res.Success)
                return BadRequest(res.Message);

            BranchResource branchRes = _mapper.Map<Branch, BranchResource>(res.SavedModel as Branch);

            return Ok(branchRes);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] AddBranchResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            Branch branch = _mapper.Map<AddBranchResource, Branch>(resource);
            SaveResponse result = await _branchService.UpdateAsync(id, branch);

            if (!result.Success)
                return BadRequest(result.Message);

            BranchResource branchResource = _mapper.Map<Branch, BranchResource>((Branch)result.SavedModel);

            return Ok(branchResource);
        }



    }
}
