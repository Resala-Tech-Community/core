using System;
using System.ComponentModel.DataAnnotations;

namespace resala.core.Resources
{
    public class AddCommitteeResource
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [Range(0,5)]
        public ushort MaleCapacity { get; set; }

        [Required]
        [Range(0, 5)]
        public ushort FemaleCapacity { get; set; }

        [Required]
        [Range(0, 5)]
        public ushort UniSexCapacity { get; set; }
    }
}
