using resala.core.Validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace resala.core.Resources
{
    public class AddBranchResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }
    }
}
