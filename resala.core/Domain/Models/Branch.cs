using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
    }
}
