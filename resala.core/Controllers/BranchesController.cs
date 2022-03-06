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
    public class BranchesController : Controller
    {
        private readonly IBranchService _branchService;


        public BranchesController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpGet]
        public async Task<IEnumerable<Branch>> GetAllAsync()
        {
            return await _branchService.ListAsync();
        }

    }
}
