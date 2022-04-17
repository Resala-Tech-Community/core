using Microsoft.EntityFrameworkCore;
using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace resala.core.Persistence.Repositories
{
    public class GenericRepositry<T> : BaseRepository, IGenericReposirty<T> where T : BaseModel
    {
        private DbSet<T> table = null;
        public GenericRepositry(AppDbContext context): base(context)
        {
            table = context.Set<T>();
        }
        public async Task AddAsync(T model)
        {
            await table.AddAsync(model);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ListAsync()
        {
            return await table.ToListAsync();
        }

        public void Remove(T model)
        {
            table.Remove(model);
        }

        public void Update(T model)
        {
            table.Update(model);
        }
    }
}
