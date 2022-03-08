using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    public class Volunteer : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }


    }
}
