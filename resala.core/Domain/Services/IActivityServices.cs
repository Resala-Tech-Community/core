using resala.core.Domain.Models;
using resala.core.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace resala.core.Domain.Services
{
    public interface IActivityServices
    {
        public IBasicService<Activity> BasicService { get; set; }
    }


    // for any extenstoins related to activity services

}
