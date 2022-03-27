using Microsoft.EntityFrameworkCore;
using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Persistence.Repositories
{
    public class VolunteerRepository : BaseRepository,IVolunteerRepository
    {
        public VolunteerRepository(AppDbContext context) : base(context)
        {

        }

        public Task AddAsync(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }

        public Task<Volunteer> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Volunteer>> ListAsync()
        {
            return await _context.Volunteers.Include(v=>v.Branch).ToListAsync();
        }

        public void Remove(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }

        public void Update(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }
    }
}
