using resala.core.Domain.Models;
using resala.core.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Services
{
    public interface IVolunteerService
    {
        Task<IEnumerable<Volunteer>> ListAsync();
        Task<ModelChangeResponse> SaveAsync(Volunteer volunteer);
        Task<ModelChangeResponse> UpdateAsync(int id, Volunteer volunteer);
        Task<ModelChangeResponse> DeleteAsync(int id);
    }
}
