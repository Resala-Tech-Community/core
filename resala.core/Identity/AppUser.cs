using Microsoft.AspNetCore.Identity;
using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Identity
{
    public class AppUser : IdentityUser
    {
        public virtual MemberVolunteer Volunteer { get; set; }
        public virtual int? MemberVolunteerID { get; set; }        
    }



}
