﻿using resala.core.Domain.Models;
using resala.core.Domain.Services.Communication;
using resala.core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Services
{
    public interface IBranchService
    {
        Task<IEnumerable<Branch>> ListAsync();
        Task<ModelChangeResponse> SaveAsync(Branch branch);
        Task<ModelChangeResponse> UpdateAsync(int id, Branch branch);
        Task<ModelChangeResponse> DeleteAsync(int id);

    }
}
