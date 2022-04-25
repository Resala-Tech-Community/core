using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Extensions;
using resala.core.Resources;
using System;

namespace resala.core.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Branch, BranchResource>();
       
            CreateMap<ResponsibleVolunteer, ResponsibleVolunteerResource>()
              .ForMember(src => src.Gender, opt => opt.MapFrom(src => src.Gender.ToDescriptionString()))
              .ForMember(src => src.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth != null ? ((DateTime)src.DateOfBirth).ToShortDateString() : null))
              .ForMember(src => src.GraduationDate, opt => opt.MapFrom(src => src.GraduationDate != null ? ((DateTime)src.GraduationDate).ToShortDateString() : null))
              .ForMember(src => src.OmraWonDate, opt => opt.MapFrom(src => src.OmraWinDate != null ? ((DateTime)src.OmraWinDate).ToShortDateString() : null))
              .ForMember(src => src.OmraTravelDate, opt => opt.MapFrom(src => src.OmraTravelDate != null ? ((DateTime)src.OmraTravelDate).ToShortDateString() : null))
              .ForMember(src => src.MiniCampQualificationDate, opt => opt.MapFrom(src => src.MiniCampQualificationDate != null ? ((DateTime)src.MiniCampQualificationDate).ToShortDateString() : null))
              .ForMember(src => src.LeadersCampQualificationDate, opt => opt.MapFrom(src => src.LeadersCampQualificationDate != null ? ((DateTime)src.LeadersCampQualificationDate).ToShortDateString() : null))
              .ForMember(src => src.DrMeetingQualificationDate, opt => opt.MapFrom(src => src.DrMeetingQualificationDate != null ? ((DateTime)src.DrMeetingQualificationDate).ToShortDateString() : null))
              .ForMember(src => src.GraduationInterviewQualificationDate, opt => opt.MapFrom(src => src.GraduationInterviewQualificationDate != null ? ((DateTime)src.GraduationInterviewQualificationDate).ToShortDateString() : null))
              .ForMember(src => src.ActivityJoinDate, opt => opt.MapFrom(src => src.ActivityJoinDate != null ? ((DateTime)src.ActivityJoinDate).ToShortDateString() : null))
              .ForMember(src => src.ExitDate, opt => opt.MapFrom(src => src.ExitDate != null ? ((DateTime)src.ExitDate).ToShortDateString() : null))
              ;
        }
    }
}
