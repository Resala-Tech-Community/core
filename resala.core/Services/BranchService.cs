using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepoitory;
        private readonly IUnitOfWork _unitOfWork;

        public BranchService(IBranchRepository branchRepoitory, IUnitOfWork unitOfWork)
        {
            _branchRepoitory = branchRepoitory;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Branch>> ListAsync()
        {
            return await _branchRepoitory.ListAsync();
        }

        public async Task<SaveResponse> SaveAsync(Branch branch)
        {
            try
            {
                await _branchRepoitory.AddAsync(branch);
                await _unitOfWork.CompleteAsync();

                return new SaveResponse(branch);

            }catch(Exception e)
            {
                return new SaveResponse($"Error while adding new branch instance: {e.Message}");
            }
        }
    }
}
