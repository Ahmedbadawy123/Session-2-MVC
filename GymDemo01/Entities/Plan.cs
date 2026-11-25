namespace GymDemo01.Entities
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public string Description { get; set; } = default!;
        public int DurationDays { get; set; }
        public bool InActive { get; set; }

        public ICollection<Membership> PlanSubscription { get; set; } = default!;
    }
}   
