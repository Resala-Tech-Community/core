using resala.core.Domain.Models;

namespace resala.core.Domain.Services
{
    public interface IVolunteerService
    {
        public IBasicService<MemberVolunteer> BasicService { get; set; }
    }
}
