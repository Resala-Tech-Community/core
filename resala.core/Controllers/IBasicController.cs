using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using resala.core.Domain.Models;
using resala.core.Domain.Services;
using resala.core.Domain.Services.Communication;
using resala.core.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace resala.core.Controllers
{
    public abstract class IBasicController<TEntity,TEntityResouece,TEntityAddResouece> : Controller where TEntity : BaseModel
    {
        protected readonly IMapper _mapper;
        protected readonly IBasicService<TEntity> _basicService;

        public IBasicController(IMapper mapper , IBasicService<TEntity> basicService)
        {
            _mapper = mapper;
            _basicService = basicService;
        }

        [HttpGet]
        public virtual async Task<IEnumerable<TEntityResouece>> GetAllAsync()
        {
            IEnumerable<TEntity> modelList = await _basicService.ListAsync();
            return _mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityResouece>>(modelList);
        }

        [HttpPost]
        public virtual async Task<IActionResult> PostAsync([FromBody] TEntityAddResouece resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            TEntity model = null;

            try
            {
                model = _mapper.Map<TEntityAddResouece, TEntity>(resource);
            }
            catch (Exception e)
            {
                return BadRequest($"Error while maping resources\nException{e}");
            }

            ModelChangeResponse res = await _basicService.SaveAsync(model);

            if (!res.Success)
                return BadRequest(res.Message);

            TEntityResouece modeResource = _mapper.Map<TEntity, TEntityResouece>(res.ChangedModel as TEntity);

            return Ok(modeResource);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> PutAsync(int id, [FromBody] TEntityAddResouece resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            TEntity model = _mapper.Map<TEntityAddResouece, TEntity>(resource);
            ModelChangeResponse result = await _basicService.UpdateAsync(id, model);

            if (!result.Success)
                return BadRequest(result.Message);

            TEntityResouece modelResource = _mapper.Map<TEntity, TEntityResouece>((TEntity)result.ChangedModel);

            return Ok(modelResource);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            ModelChangeResponse result = await _basicService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var modelResouece = _mapper.Map<TEntity, TEntityResouece>((TEntity)result.ChangedModel);

            return Ok(modelResouece);
        }
    }
}
