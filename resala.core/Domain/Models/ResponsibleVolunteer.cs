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

        public int Id { get; set; }


        // Emergency Contacts
        [Required(ErrorMessage = "Required")]
        public MaleRelativeRelation MaleRelativeRelation { get; set; }

        [Required(ErrorMessage = "Required")]
        public string MaleRelativeName { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string MaleRelativePhoneNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        public FemaleRelativeRelation FemaleRelativeRelation { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FemaleRelativeName { get; set; }

        [RegularExpression("0\\d{10}", ErrorMessage = "Invalid phone number")]
        public string FemalteRelativePhoneNumber { get; set; }


        // Resala Graduation Information

        [Required(ErrorMessage = "Required")]
        public bool ResalaGraduated { get; set; }

        public string GraduationGroupNumber { get; set; }

        public DateTime? GraduationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsOmraWinner { get; set; }

        public DateTime? OmraWinDate { get; set; }

        public DateTime? OmraTravelDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsMiniCampQualifed { get; set; }

        public DateTime? MiniCampQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsLeadersCampQualifed { get; set; }

        public DateTime? LeadersCampQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsDrMeetingQualifed { get; set; }

        public DateTime? DrMeetingQualificationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsGraduationInterviewQualifed { get; set; }

        public DateTime? GraduationInterviewQualificationDate { get; set; }

        // Activity Infromation

        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
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


        public int? CommitteeId { get; set; }
        public virtual Committee Committee { get; set; }

        public bool IsSocialMediaGroupsMember { get; set; }


        // Exit Information

        public DateTime? ExitDate { get; set; }
        public string ExitReason { get; set; }

        // General 

        public string Notes { get; set; }


        //TODO: awards


    }
}
