using resala.core.Domain.Models;
using resala.core.Validation.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace resala.core.Domain.Models
{
    [Table("TrackRecords")]
    public class TrackRecord : BaseModel
    {

        public TrackRecord()
        {
            CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public DateTime? CreatedDate { get; set; }

        [Required]
        public DateTime? AttendedDate { get; set; }

        [Required]
        public int? ResponsibleVolunteerId { get; set; }
        public virtual MemberVolunteer Volunteer { get; set; }

        [Required]
        public int? TrackerId { get; set; }
        public virtual Tracker Tracker { get; set; }

        [Range(0,500)]
        public int Expenses { get; set; }

        public bool? IsSettled { get; set; }

        [Required]
        [Range(1,24)]
        public int Hours { get; set; }

        public string RequiredInfo { get; set; }

        [Required]
        public TrackRecordStatus Status { get; set; }


    }
}
