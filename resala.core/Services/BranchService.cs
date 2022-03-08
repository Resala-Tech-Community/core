using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using System;
using System.Collections.Generic;
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

        public async Task<SaveResponse> UpdateAsync(int id, Branch branch)
        {
            var existingCategory = await _branchRepoitory.FindByIdAsync(id);

            if (existingCategory == null)
                return new SaveResponse("Branch not found.");

            existingCategory.Name = branch.Name;

            try
            {
                _branchRepoitory.Update(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new SaveResponse(existingCategory);
            }
            catch (Exception ex)
            {
                return new SaveResponse($"An error occurred when updating the branch: {ex.Message}");
            }
        }
    }
}
