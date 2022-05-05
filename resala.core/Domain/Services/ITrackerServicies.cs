using resala.core.Domain.Models;

namespace resala.core.Domain.Services
{
    public interface ITrackerServicies
    {
        public IBasicService<Tracker> BasicService { get; set; }
    }
}
