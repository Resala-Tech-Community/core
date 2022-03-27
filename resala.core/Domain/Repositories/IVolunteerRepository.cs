using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Repositories
{
    public interface IVolunteerRepository
    {
        Task<IEnumerable<Volunteer>> ListAsync();
        Task AddAsync(Volunteer volunteer);
        Task<Volunteer> FindByIdAsync(int id);
        void Update(Volunteer volunteer);
        void Remove(Volunteer volunteer);
    }
}
