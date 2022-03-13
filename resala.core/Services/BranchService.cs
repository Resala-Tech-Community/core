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

        public async Task<ModelChangeResponse> DeleteAsync(int id)
        {
            Branch existingBranch = await _branchRepoitory.FindByIdAsync(id);

            if (existingBranch == null)
                return new ModelChangeResponse("Branch not found.");

            try
            {
                _branchRepoitory.Remove(existingBranch);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(existingBranch);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new ModelChangeResponse($"An error occurred when deleting the branch: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Branch>> ListAsync()
        {
            return await _branchRepoitory.ListAsync();
        }

        public async Task<ModelChangeResponse> SaveAsync(Branch branch)
        {
            try
            {
                await _branchRepoitory.AddAsync(branch);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(branch);

            }catch(Exception e)
            {
                return new ModelChangeResponse($"Error while adding new branch instance: {e.Message}");
            }
        }

        public async Task<ModelChangeResponse> UpdateAsync(int id, Branch branch)
        {
            var existingBranch = await _branchRepoitory.FindByIdAsync(id);

            if (existingBranch == null)
                return new ModelChangeResponse("Branch not found.");

            existingBranch.Name = branch.Name;

            try
            {
                _branchRepoitory.Update(existingBranch);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(existingBranch);
            }
            catch (Exception ex)
            {
                return new ModelChangeResponse($"An error occurred when updating the branch: {ex.Message}");
            }
        }
    }
}
