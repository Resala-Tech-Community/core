using resala.core.Domain.Models;
using resala.core.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Repositories
{
    public interface IBranchRepository
    {
        Task<IEnumerable<Branch>> ListAsync();
        Task AddAsync(Branch branch);
        Task<Branch> FindByIdAsync(int id);
        void Update(Branch branch);

    }
}
