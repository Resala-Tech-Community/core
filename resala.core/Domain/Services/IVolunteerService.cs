using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Services
{
    public interface IVolunteerService
    {
        Task<IEnumerable<Volunteer>> ListAsync();
    }
}
