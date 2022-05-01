using resala.core.Domain.Models;

namespace resala.core.Domain.Services
{
    public interface IVolunteerService
    {
        public IBasicService<ResponsibleVolunteer> BasicService { get; set; }
    }
}
