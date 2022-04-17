using resala.core.Validation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    public class ResponsibleVolunteer : IVolunteer
    {

        public ResponsibleVolunteer()
        {
            VolunteerType = VolunteerType.Member;
        }

        // Emergency Contacts
        [Required(ErrorMessage = "Required")]
        public MaleRelativeRelation MaleRelativeRelation { get; set; }

        [Required(ErrorMessage = "Required")]
        public string MaleRelativeName { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string MaleRelativePhoneNumber { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public FemaleRelativeRelation FemaleRelativeRelation { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string FemaleRelativeName { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string FemalteRelativePhoneNumber { get; set; }


        // Resala Graduation Information

        [Required(ErrorMessage = "Required")]
        public bool ResalaGraduated { get; set; }

        [Required(ErrorMessage = "Required")]
        public string GraduationGroupNumber { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid graduation date")]
        public DateTime? GraduationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsOmraWinner { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid winning omra date")]
        public DateTime? OmraWinDate { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid omra travel date")]
        public DateTime? OmraTravelDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsMiniCampQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid mini camp attendance date")]
        public DateTime? MiniCampQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsLeadersCampQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid leader camp attendence date")]
        public DateTime? LeadersCampQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsDrMeetingQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid Dr meeting attendence date")]
        public DateTime? DrMeetingQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsGraduationInterviewQualifed { get; set; }

        [ValidPastDate(ErrorMessage = "Invalid interview attendence date")]
        public DateTime? GraduationInterviewQualificationDate { get; set; }

        // Activity Infromation


        public Activity Activity { get; set; }
        public DateTime? ActivityJoinDate { get; set; }
        public string JoiningObjectives { get; set; }

        // Previous Experince

        public string PreviousExperince { get; set; }

        // Documents

        public string ProfileImage { get; set; }
        public string NationalIdCopy { get; set; }
        // public IList<string> Images { get; set; }

        // Data Policies Consent

        public bool IsActivityPolicyAgreed { get; set; }
        public bool IsDataPrivacyPolicyAgreed { get; set; }

        // Hierarchical Information 

        public VolunteeringStatus WorkingStatus { get; set; }
        public Position Position { get; set; }

        //public int BranchId { get; set; }
        public Branch Branch { get; set; }

        //public int CommitteeId { get; set; }
        public Committee Committee { get; set; }

        public bool IsSocialMediaGroupsMember { get; set; }


        // Exit Information

        public DateTime? ExitDate { get; set; }
        public string ExitReason { get; set; }

        // General 

        public string Notes { get; set; }


        //TODO: awards


    }
}
