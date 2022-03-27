using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    public class Volunteer : BaseModel
    {
        public int Id { get; set; }

        // Personal Information
        public string Name { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalIdNumber { get; set; }
        public string ResidenceArea { get; set; }

        // Emergency Contacts

        public MaleRelativeRelation MaleRelativeRelation { get; set; }
        public string MaleRelativeName { get; set; }
        public string MaleRelativeNumber { get; set; }

        public FemaleRelativeRelation FemaleRelativeRelation { get; set; }
        public string FemaleRelativeName { get; set; }
        public string FemalteRelativeNumber { get; set; }

        // Educational Information

        public EducationalDegree EducationalDegree { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public ushort AcademicYear { get; set; }
        public bool Graduated { get; set; }

        // Resala Graduation Information

        public bool ResalaGraduated { get; set; }
        public ushort GraduationGroupNumber { get; set; }
        public DateTime GraduationDate { get; set; }

        public bool IsOmraWinner { get; set; }
        public DateTime WonDate { get; set; }
        public DateTime TravelDate { get; set; }

        public bool IsMiniCampQualifed { get; set; }
        public DateTime MiniCampQualificationDate { get; set; }

        public bool IsLeadersCampQualifed { get; set; }
        public DateTime LeadersCampQualificationDate { get; set; }

        public bool IsDrMeetingQualifed { get; set; }
        public DateTime DrMeetingQualificationDate { get; set; }

        public bool IsInterviewQualifed { get; set; }
        public DateTime InterviewQualificationDate { get; set; }



        // Activity Infromation

        public DateTime ActivityJoinDate { get; set; }
        public string JoiningObjectives { get; set; }

        // Previous Experince

        public string PreviousExperince { get; set; }

        // Documents

        public string ProfileImagePath { get; set; }
        public string NationalIdPath { get; set; }
        public IList<string> Images { get; set; }

        // Data Policies Consent

        public bool IsActivityPolicyAgreed { get; set; }
        public bool IsDataPrivacyPolicyAgreed { get; set; }

        // Hierarchical Information 

        public VolunteeringStatus WorkingStatus { get; set; }
        public VolunteerType VolunteerType { get; set; }
        public Position Position { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public int CommitteeId { get; set; }
        public Committee Committee { get; set; }

        public bool IsSocialMediaGroupsMember { get; set; }


        // Exit Information

        public DateTime ExitDate { get; set; }
        public string ExitReason { get; set; }

        // General 

        public string Notes { get; set; }


        //TODO: awards




    }
}
