using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    public enum VolunteeringStatus : byte
    {
        Active =1 , 
        Resigned =2,
        Dismissed =3,
        OnVacation =4,
        Pending =5
    }
}
