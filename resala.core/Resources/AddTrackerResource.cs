using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Resources
{
    public class AddTrackerResource
    {
        [Required]
        public string Location { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(20)]
        public string RequiredInfo { get; set; } = "No Required Info";
    }
}
