using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Resources;

namespace resala.core.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Volunteer, VolunteerResource>();
            CreateMap<Branch, BranchResource>();
        }
    }
}
