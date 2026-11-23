using MVC02.Entities.Enums;

namespace MVC02.Entities
{
    public class Trainer : GymUser
    {
        public Specialities Speciality { get; set; }

        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
