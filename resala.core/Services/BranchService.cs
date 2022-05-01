using resala.core.Domain.Models;
using resala.core.Domain.Services;

namespace resala.core.Services
{
    public class BranchService : IBranchService
    {
        public IBasicService<Branch> BasicService { get; set; }

        public BranchService(IBasicService<Branch> basicService)
        {
            BasicService = basicService;
        }
    }
}
