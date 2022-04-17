using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Repositories
{
    public interface IGenericReposirty<T> where T : BaseModel
    {
        Task<IEnumerable<T>> ListAsync();
        Task AddAsync(T model);
        Task<T> FindByIdAsync(int id);
        void Update(T model);
        void Remove(T model);
    }
}
