using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Resources
{
    public class AddVolunteerResources
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

        public Branch Branch { get; set; }

    }
}
