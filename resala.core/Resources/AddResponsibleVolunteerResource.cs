using resala.core.Validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace resala.core.Resources
{
    public class AddResponsibleVolunteerResource
    {

        // Personal Information
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression("\\d{14}", ErrorMessage = "Invalid national ID")]
        public string NationalIdNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ResidenceArea { get; set; }


        // Educational Information

        [Required(ErrorMessage = "Required")]
        public string EducationalDegree { get; set; }

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

        // Emergency Contacts
        [Required(ErrorMessage = "Required")]
        public string MaleRelativeRelation { get; set; }

        [Required(ErrorMessage = "Required")]
        public string MaleRelativeName { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string MaleRelativePhoneNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FemaleRelativeRelation { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FemaleRelativeName { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string FemalteRelativePhoneNumber { get; set; }


        // Resala Graduation Information

        [Required(ErrorMessage = "Required")]
        public bool ResalaGraduated { get; set; }

        public string GraduationGroupNumber { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string GraduationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsOmraWinner { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string OmraWinDate { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string OmraTravelDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsMiniCampQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string MiniCampQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsLeadersCampQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string LeadersCampQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsDrMeetingQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string DrMeetingQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsGraduationInterviewQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string GraduationInterviewQualificationDate { get; set; }


        [Required(ErrorMessage = "Required")]
        [ValidPastDate(ErrorMessage = "Invalid date of birth")]
        public string ActivityJoinDate { get; set; }

        public string JoiningObjectives { get; set; }

        // Previous Experince

        public string PreviousExperince { get; set; }

        // Documents

        public string ProfileImage { get; set; }
        public string NationalIdCopy { get; set; }
        // public IList<string> Images { get; set; }

        // Data Policies Consent

        [Required(ErrorMessage = "Required")]
        public bool IsActivityPolicyAgreed { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsDataPrivacyPolicyAgreed { get; set; }

        // Hierarchical Information 
        [Required(ErrorMessage = "Required")]
        public int BranchId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int ActivityId { get; set; }

        public int? CommitteeId { get; set; }

    }
}
