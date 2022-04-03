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

            CreateMap<Volunteer, VolunteerResource>()
              .ForMember(src => src.Gender, opt => opt.MapFrom(src => src.Gender.ToDescriptionString()))
              .ForMember(src => src.DateOfBirth, opt => opt.MapFrom(src => ((DateTime)src.DateOfBirth).ToShortDateString()))
              .ForMember(src => src.GraduationDate, opt => opt.MapFrom(src => ((DateTime)src.GraduationDate).ToShortDateString()))
              .ForMember(src => src.WonDate, opt => opt.MapFrom(src => ((DateTime)src.WonDate).ToShortDateString()))
              .ForMember(src => src.TravelDate, opt => opt.MapFrom(src => ((DateTime)src.TravelDate).ToShortDateString()))
              .ForMember(src => src.MiniCampQualificationDate, opt => opt.MapFrom(src => ((DateTime)src.MiniCampQualificationDate).ToShortDateString()))
              .ForMember(src => src.LeadersCampQualificationDate, opt => opt.MapFrom(src => ((DateTime)src.LeadersCampQualificationDate).ToShortDateString()))
              .ForMember(src => src.DrMeetingQualificationDate, opt => opt.MapFrom(src => ((DateTime)src.DrMeetingQualificationDate).ToShortDateString()))
              .ForMember(src => src.InterviewQualificationDate, opt => opt.MapFrom(src => ((DateTime)src.InterviewQualificationDate).ToShortDateString()))
              .ForMember(src => src.ActivityJoinDate, opt => opt.MapFrom(src => ((DateTime)src.ActivityJoinDate).ToShortDateString()))
              .ForMember(src => src.ExitDate, opt => opt.MapFrom(src => ((DateTime)src.ExitDate).ToShortDateString()))
              ;
        }
    }
}
