using resala.core.Domain.Models;
using resala.core.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Services
{
    public interface IBranchService
    {
        Task<IEnumerable<Branch>> ListAsync();
        Task<SaveResponse> SaveAsync(Branch branch);
        Task<SaveResponse> UpdateAsync(int id, Branch branch);
    }
}
