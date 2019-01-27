using System.Data.Entity;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository
{
    public partial class CodingChallengeContext : DbContext
    {
        public CodingChallengeContext() : base("name=cc_db")
        {
        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserProject> UserProjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(e => e.UserProjects)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserProjects)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
