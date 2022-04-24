using resala.core.Validation.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace resala.core.Domain.Models
{
    public abstract class IVolunteer : BaseModel
    {
        // Personal Information
        [Required(ErrorMessage ="Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression("0\\d{10}",ErrorMessage ="Invalid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Required")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [ValidPastDate(ErrorMessage ="Invalid date of birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression("\\d{14}", ErrorMessage = "Invalid national ID")]
        public string NationalIdNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ResidenceArea { get; set; }


        // Educational Information

        [Required(ErrorMessage = "Required")]
        public EducationalDegree EducationalDegree { get; set; }

        [Required(ErrorMessage = "Required")]
        public string University { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Faculty { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Specialization { get; set; }

        [Required(ErrorMessage = "Required")]
        public ushort AcademicYear { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool Graduated { get; set; }


        public virtual VolunteerType VolunteerType { get; set; } = VolunteerType.Visitor;


        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }



    }
}
