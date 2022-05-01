using AutoMapper;
using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace resala.core.Services
{
    public class BasicService<T> : IBasicService<T> where T : BaseModel 
    {
        private readonly IGenericReposirty<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BasicService(IGenericReposirty<T> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ModelChangeResponse> DeleteAsync(int id)
        {
            T existingModel = await _repository.FindByIdAsync(id);

            if (existingModel == null)
                return new ModelChangeResponse("Model not found.");

            try
            {
                _repository.Remove(existingModel);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(existingModel);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new ModelChangeResponse($"An error occurred when deleting the model: {ex.Message}");
            }
        }

        public async Task<IEnumerable<T>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<ModelChangeResponse> SaveAsync(T model)
        {
            try
            {

                await _repository.AddAsync(model);
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(model);

            }
            catch (Exception e)
            {
                return new ModelChangeResponse($"Error while adding new model instance: {e.Message}");
            }
        }

        public async Task<ModelChangeResponse> UpdateAsync(int id, T model)
        {
            var existingModel = await _repository.FindByIdAsync(id);

            if (existingModel == null)
                return new ModelChangeResponse("Model not found.");

            _mapper.Map(model, existingModel);

            try
            {
                await _unitOfWork.CompleteAsync();

                return new ModelChangeResponse(existingModel);
            }
            catch (Exception ex)
            {
                return new ModelChangeResponse($"An error occurred when updating the model: {ex.Message}");
            }
        }
    }
}
