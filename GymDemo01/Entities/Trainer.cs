using GymDemo01.Entities.Enums;

namespace GymDemo01.Entities
{
    public class Trainer : GymUser
    {
        public Specialities Speciality { get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
