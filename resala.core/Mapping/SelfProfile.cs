using AutoMapper;
using resala.core.Domain.Models;

namespace resala.core.Mapping
{
    public class SelfProfile : Profile
    {
        public SelfProfile()
        {
            CreateMap<ResponsibleVolunteer, ResponsibleVolunteer>()
               .ForMember(src => src.Id, opt => opt.Ignore());

            CreateMap<Activity, Activity>()
              .ForMember(src => src.Id, opt => opt.Ignore());

            CreateMap<Branch, Branch>()
              .ForMember(src => src.Id, opt => opt.Ignore());

            CreateMap<Committee, Committee>()
              .ForMember(src => src.Id, opt => opt.Ignore());

            CreateMap<Tracker, Tracker>()
              .ForMember(src => src.Id, opt => opt.Ignore());

            CreateMap<TrackRecord, TrackRecord>()
             .ForMember(src => src.Id, opt => opt.Ignore());
        }
    }
}
