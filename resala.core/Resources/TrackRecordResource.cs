using System;

namespace resala.core.Resources
{
    public class TrackRecordResource
    {
        public int Id { get; set; }

        public string CreatedDate { get; set; }

        public string AttendedDate { get; set; }

        public ResponsibleVolunteerResource Volunteer { get; set; }

        public TrackerResource Tracker { get; set; }

        public string Expenses { get; set; }

        public string IsSettled { get; set; }

        public string Hours { get; set; }

        public string RequiredInfo { get; set; }

        public string Status { get; set; }
    }
}
