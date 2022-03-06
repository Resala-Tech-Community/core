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
    public class BranchRepository : BaseRepository,IBranchRepository
    {
        public BranchRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Branch>> ListAsync()
        {
            return await _context.Branches.ToListAsync();
        }
    }
}
