using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace resala.core.Domain.Models
{
    [Table("Trackers")]
    public class Tracker : BaseModel
    {
        public int Id { get; set; }

        [Required]
        public TrackerLocation Location { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(20)]
        public string RequiredInfoHint { get; set; }

        [Range(0, 30)]
        public int RecordPeriodDays { get; set; }

    }
}
