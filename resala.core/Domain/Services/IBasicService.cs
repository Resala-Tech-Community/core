using resala.core.Domain.Models;
using resala.core.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace resala.core.Domain.Services
{
    public interface IBasicService<T> where T : BaseModel
    {
        Task<IEnumerable<T>> ListAsync();
        Task<ModelChangeResponse> SaveAsync(T committee);
        Task<ModelChangeResponse> UpdateAsync(int id, T committee);
        Task<ModelChangeResponse> DeleteAsync(int id);
    }
}
