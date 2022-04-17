﻿using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Resources
{
    public class AddResponsibleVolunteerResource
    {

        // Personal Information
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string NationalIdNumber { get; set; }
        public string ResidenceArea { get; set; }

        // Emergency Contacts

        public string MaleRelativeRelation { get; set; }
        public string MaleRelativeName { get; set; }
        public string MaleRelativeNumber { get; set; }

        public string FemaleRelativeRelation { get; set; }
        public string FemaleRelativeName { get; set; }
        public string FemalteRelativeNumber { get; set; }

        // Educational Information

        public string EducationalDegree { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public ushort AcademicYear { get; set; }
        public bool Graduated { get; set; }

        // Resala Graduation Information

        public bool ResalaGraduated { get; set; }
        public ushort GraduationGroupNumber { get; set; }
        public string GraduationDate { get; set; }

        public bool IsOmraWinner { get; set; }
        public string WonDate { get; set; }
        public string TravelDate { get; set; }

        public bool IsMiniCampQualifed { get; set; }
        public string MiniCampQualificationDate { get; set; }

        public bool IsLeadersCampQualifed { get; set; }
        public string LeadersCampQualificationDate { get; set; }

        public bool IsDrMeetingQualifed { get; set; }
        public string DrMeetingQualificationDate { get; set; }

        public bool IsInterviewQualifed { get; set; }
        public string InterviewQualificationDate { get; set; }



        // Activity Infromation

        public string ActivityJoinDate { get; set; }
        public string JoiningObjectives { get; set; }

        // Previous Experince

        public string PreviousExperince { get; set; }

        // Documents

        public string ProfileImagePath { get; set; }
        public string NationalIdPath { get; set; }
        //public IList<string> Images { get; set; }

        // Data Policies Consent

        public bool IsActivityPolicyAgreed { get; set; }
        public bool IsDataPrivacyPolicyAgreed { get; set; }

        // Hierarchical Information 

        public string WorkingStatus { get; set; }
        public string VolunteerType { get; set; }
        public string Position { get; set; }

        public string BranchName { get; set; }
        public string CommitteeName { get; set; }

        public bool IsSocialMediaGroupsMember { get; set; }


        // Exit Information

        public string ExitDate { get; set; }
        public string ExitReason { get; set; }

        // General 

        public string Notes { get; set; }

    }
}