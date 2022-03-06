using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepoitory;

        public BranchService(IBranchRepository branchRepoitory)
        {
            _branchRepoitory = branchRepoitory;
        }

        public async Task<IEnumerable<Branch>> ListAsync()
        {
            return await _branchRepoitory.ListAsync();
        }
    }
}
