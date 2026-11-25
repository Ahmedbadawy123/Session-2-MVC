namespace GymDemo01.Entities
{
    public class Member : GymUser
    {
        public string? Photo { get; set; } // We Will Make For it Modification    
        public ICollection<Membership> MemberSubscription { get; set; } = default!;
    }
}
