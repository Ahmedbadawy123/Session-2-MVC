using GymDemo01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymDemo01.Contexts.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(E => E.Id); // The Id Of The BaseEntity

            builder.Property(X => X.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");
        }
    }
}
