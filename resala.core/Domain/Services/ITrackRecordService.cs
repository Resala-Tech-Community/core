using resala.core.Domain.Models;

namespace resala.core.Domain.Services
{
    public interface ITrackRecordService
    {
        public IBasicService<TrackRecord> BasicService { get; set; }

    }
}
