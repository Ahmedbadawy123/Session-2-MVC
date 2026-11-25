using GymDemo01.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymDemo01.Contexts
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymSystem;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Fluent API configurations , And Make it Before The Migration
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Btro7 Tdwr Fy El Application 3la Ay 7aga Bt Implement EL Interface IEntityTypeConfiguration.
            // Note : The File Build (DLL) Dh Assembly Mn Osol El Application.
        }
        
        #region DbSets
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions { get; set; }

        #endregion
    }
}
