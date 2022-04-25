using resala.core.Domain.Models;
using resala.core.Domain.Services.Communication;
using resala.core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Services
{
    public interface IVolunteerService
    {
        Task<IEnumerable<ResponsibleVolunteer>> ListAsync();
        Task<ModelChangeResponse> SaveAsync(ResponsibleVolunteer volunteer);
        Task<ModelChangeResponse> UpdateAsync(int id, ResponsibleVolunteer volunteer);
        Task<ModelChangeResponse> DeleteAsync(int id);
    }
}
