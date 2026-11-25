using GymDemo01.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymDemo01.Contexts.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser // Any One Use GymUserConfigurations is Inheriting from GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name)
                   .HasColumnType("VarChar")
                   .HasMaxLength(50);
            
            builder.Property(X => X.Phone)
                   .HasColumnType("VarChar")
                   .HasMaxLength(11);

            builder.Property(X => X.Email)
                   .HasColumnType("VarChar")
                   .HasMaxLength(100);

            builder.ComplexProperty(X => X.Address);
            // ComplexProperty -> Hwa Hya5od ElProperty Ely H7ddholo Fy Elclass Ely Hwa ElAddress W Ybd2 En Hwa Ywz3hom 3ala Kol ElClasses.

            builder.HasIndex(X => X.Email).IsUnique();
            builder.HasIndex(X => X.Phone).IsUnique();

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck" , "Email LIKE '%@%.com'");
                T.HasCheckConstraint("GymUser_PhoneCheck", "LEN(Phone) = 11 AND (Phone LIKE'010%' OR Phone LIKE'011%' OR Phone LIKE'012%' OR Phone LIKE'015%')");
            });
        }
    }
}
