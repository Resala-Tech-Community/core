using resala.core.Domain.Models;

namespace resala.core.Domain.Services
{
    public interface IBranchService
    {
        public IBasicService<Branch> BasicService { get; set; }
    }
}
