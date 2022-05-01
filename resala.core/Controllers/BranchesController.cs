using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using resala.core.Resources;

namespace resala.core.Controllers
{
    [Route("/api/[controller]")]
    public class BranchesController : IBasicController<Branch, BranchResource, AddBranchResource>
    {
        private readonly IBranchService _branchService;

        public BranchesController(IBranchService branchService, IMapper mapper) : base(mapper, branchService.BasicService)
        {
            _branchService = branchService;
        }
    }
}

