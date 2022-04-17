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
    public class VolunteerService : IVolunteerService
    {
        private readonly IGenericReposirty<ResponsibleVolunteer> _volunteerRepository;
        private readonly IUnitOfWork _unitOfWork;


        public VolunteerService(IGenericReposirty<ResponsibleVolunteer> volunteerRepository, IUnitOfWork unitOfWork)
        {
            _volunteerRepository = volunteerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ModelChangeResponse> DeleteAsync(int id)
        {
            ResponsibleVolunteer existingVolunteer = await _volunteerRepository.FindByIdAsync(id);

            if (existingVolunteer == null)
                return new ModelChangeResponse("Volunteer not found.");

            try
            {
                _volunteerRepository.Remove(existingVolunteer);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(existingVolunteer);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new ModelChangeResponse($"An error occurred when deleting the volunteer: {ex.Message}");
            }
        }

        public async Task<IEnumerable<ResponsibleVolunteer>> ListAsync()
        {
            return await _volunteerRepository.ListAsync();
        }

        public async Task<ModelChangeResponse> SaveAsync(ResponsibleVolunteer volunteer)
        {
            try
            {
                await _volunteerRepository.AddAsync(volunteer);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(volunteer);

            }
            catch (Exception e)
            {
                return new ModelChangeResponse($"Error while adding new volunteer instance: {e.Message}");
            }
        }

        public async Task<ModelChangeResponse> UpdateAsync(int id, ResponsibleVolunteer volunteer)
        {
            var existingVolunteer = await _volunteerRepository.FindByIdAsync(id);

            if (existingVolunteer == null)
                return new ModelChangeResponse("Volunteer not found.");

            existingVolunteer.Name = volunteer.Name;

            try
            {
                _volunteerRepository.Update(existingVolunteer);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(existingVolunteer);
            }
            catch (Exception ex)
            {
                return new ModelChangeResponse($"An error occurred when updating the volunteer: {ex.Message}");
            }
        }
    }
}
