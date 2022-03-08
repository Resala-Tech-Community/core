using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Resources
{
    public class AddBranchResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
