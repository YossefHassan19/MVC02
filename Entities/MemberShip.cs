using System.ComponentModel.DataAnnotations.Schema;

namespace MVC02.Entities
{
    public class MemberShip : BaseEntity
    {
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //column status not a column in the database
        [NotMapped]
        public String Status => StartDate > DateTime.Now ? "Upcoming"
                              : EndDate > DateTime.Now ? "Active" 
                              : "Expired";

    }
}

