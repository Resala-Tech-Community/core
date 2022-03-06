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

    }
}
