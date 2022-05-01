using System.ComponentModel.DataAnnotations;

namespace resala.core.Resources
{
    public class AddActivityResource
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
