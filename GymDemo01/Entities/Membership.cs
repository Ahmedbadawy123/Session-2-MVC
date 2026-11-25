using System.ComponentModel.DataAnnotations.Schema;

namespace GymDemo01.Entities
{
    public class Membership : BaseEntity  // Composite Entity
    {
        public int MemberId { get; set; } // FK
        public Member Member { get; set; }
        public int PlanId { get; set; } // FK
        public Plan Plan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Column Status [Not a Column In The Database] -> So We Will Use [NotMapped] 
        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming" 
                                : EndDate > DateTime.Now ? "Active" 
                                : "Expired";

    }
}
