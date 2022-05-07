using resala.core.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace resala.core.Resources
{
    public class AddTrackRecordResource
    {
        [Required]
        public string AttendedDate { get; set; }

        [Required]
        public int? ResponsibleVolunteerId { get; set; }

        [Required]
        public int? TrackerId { get; set; }

        public int Expenses { get; set; } = 0;

        public string IsSettled { get; set; }

        [Required]
        [Range(1,24)]
        public int Hours { get; set; }

        public string RequiredInfo { get; set; }
    }
}
