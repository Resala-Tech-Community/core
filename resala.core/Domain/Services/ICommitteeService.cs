using resala.core.Domain.Models;

namespace resala.core.Domain.Services
{
    public interface ICommitteeService
    {
        public IBasicService<Committee> BasicService { get; set; }
    }
}
