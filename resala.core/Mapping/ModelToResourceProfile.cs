using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Extensions;
using resala.core.Resources;

namespace resala.core.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Volunteer, VolunteerResource>();
            CreateMap<Branch, BranchResource>();

            CreateMap<Volunteer, VolunteerResource>()
              .ForMember(src => src.Gender,
               opt => opt.MapFrom(src => src.Gender.ToDescriptionString()));

        }
    }
}
