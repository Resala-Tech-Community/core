using resala.core.Domain.Models;

namespace resala.core.Resources
{
    public class VolunteerResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }

    }
}
