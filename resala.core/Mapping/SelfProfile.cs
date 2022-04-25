using AutoMapper;
using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Mapping
{
    public class SelfProfile : Profile
    {
        public SelfProfile()
        {
            CreateMap<ResponsibleVolunteer, ResponsibleVolunteer>()
               .ForMember(src => src.Id, opt => opt.Ignore());

            CreateMap<Branch, Branch>()
              .ForMember(src => src.Id, opt => opt.Ignore());
        }
    }
}
