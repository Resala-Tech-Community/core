using System;

namespace resala.core.Domain.Models
{
    public enum TrackRecordStatus : Byte
    {
        Draft = 1,
        Submitted = 2,
        Pending = 3,
        Approved = 4,
        Rejected = 5, 
        Reported =6
    }
}
