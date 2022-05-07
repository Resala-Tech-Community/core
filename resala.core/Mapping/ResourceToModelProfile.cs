using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Resources;
using System;

namespace resala.core.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<AddBranchResource, Branch>();
            CreateMap<AddActivityResource, Activity>();
            CreateMap<AddCommitteeResource, Committee>()
                .ForMember(src => src.CommitteeType, opt => opt.MapFrom(src => Enum.Parse(typeof(CommitteeType), src.CommitteeType)));


            CreateMap<AddTrackerResource, Tracker>()
                .ForMember(src => src.Location , opt => opt.MapFrom(src => Enum.Parse(typeof(TrackerLocation), src.Location)));

            CreateMap<AddTrackRecordResource, TrackRecord>()
                .ForMember(src => src.AttendedDate, opt => opt.MapFrom(src => DateTime.Parse(src.AttendedDate)));


            CreateMap<AddResponsibleVolunteerResource, ResponsibleVolunteer>()
              .ForMember(src => src.Gender, opt => opt.MapFrom(src => Enum.Parse(typeof(Gender),src.Gender)))
              .ForMember(src => src.DateOfBirth, opt => opt.MapFrom(src => DateTime.Parse(src.DateOfBirth)))
              .ForMember(src => src.GraduationDate, opt => { opt.Condition(src => !string.IsNullOrEmpty(src.GraduationDate)); opt.MapFrom(src => DateTime.Parse(src.GraduationDate)); })
              .ForMember(src => src.MaleRelativeRelation, opt => opt.MapFrom(src => Enum.Parse(typeof(MaleRelativeRelation), src.MaleRelativeRelation)))
              .ForMember(src => src.FemaleRelativeRelation, opt => opt.MapFrom(src => Enum.Parse(typeof(FemaleRelativeRelation), src.FemaleRelativeRelation)))
              .ForMember(src => src.EducationalDegree, opt => opt.MapFrom(src => Enum.Parse(typeof(EducationalDegree), src.EducationalDegree)))
              .ForMember(src => src.OmraWinDate, opt => { opt.Condition(src => !string.IsNullOrEmpty(src.OmraWinDate)); opt.MapFrom(src => DateTime.Parse(src.OmraWinDate)); })
              .ForMember(src => src.OmraTravelDate, opt => { opt.Condition(src => !string.IsNullOrEmpty(src.OmraTravelDate)); opt.MapFrom(src => DateTime.Parse(src.OmraTravelDate)); })
              .ForMember(src => src.MiniCampQualificationDate, opt => { opt.Condition(src => !string.IsNullOrEmpty(src.MiniCampQualificationDate)); opt.MapFrom(src => DateTime.Parse(src.MiniCampQualificationDate)); })
              .ForMember(src => src.LeadersCampQualificationDate, opt => { opt.Condition(src => !string.IsNullOrEmpty(src.LeadersCampQualificationDate)); opt.MapFrom(src => DateTime.Parse(src.LeadersCampQualificationDate)); })
              .ForMember(src => src.DrMeetingQualificationDate, opt => { opt.Condition(src => !string.IsNullOrEmpty(src.DrMeetingQualificationDate)); opt.MapFrom(src => DateTime.Parse(src.DrMeetingQualificationDate)); })
              .ForMember(src => src.GraduationInterviewQualificationDate, opt => { opt.Condition(src => !string.IsNullOrEmpty(src.GraduationInterviewQualificationDate)); opt.MapFrom(src => DateTime.Parse(src.GraduationInterviewQualificationDate)); })
              .ForMember(src => src.ActivityJoinDate, opt => opt.MapFrom(src => DateTime.Parse(src.ActivityJoinDate)))

              ;
        }
    }
}
