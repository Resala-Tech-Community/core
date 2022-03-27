using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    public class Branch : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }

        public IList<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
    }
}
