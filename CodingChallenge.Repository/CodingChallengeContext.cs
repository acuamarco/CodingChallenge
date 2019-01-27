using Microsoft.EntityFrameworkCore;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository
{
    public partial class CodingChallengeContext : DbContext
    {
        private readonly IDataSeed dataSeed;

        public CodingChallengeContext(IDataSeed dataSeed)
        {
            this.dataSeed = dataSeed;
        }

        public CodingChallengeContext(DbContextOptions<CodingChallengeContext> options, IDataSeed dataSeed) : base(options)
        {
            this.dataSeed = dataSeed;
        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserProject> UserProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasKey(e => e.Id);
            modelBuilder.Entity<Project>().HasMany(e => e.UserProjects);
            modelBuilder.Entity<Project>().HasData(dataSeed.GetProjects());

            modelBuilder.Entity<User>().HasKey(e => e.Id);
            modelBuilder.Entity<User>().Property(e => e.FirstName).IsUnicode(false);
            modelBuilder.Entity<User>().Property(e => e.LastName).IsUnicode(false);
            modelBuilder.Entity<User>().HasMany(e => e.UserProjects);
            modelBuilder.Entity<User>().HasData(dataSeed.GetUsers());

            modelBuilder.Entity<UserProject>().HasKey(e => new { e.UserId, e.ProjectId});
            modelBuilder.Entity<UserProject>().HasData(dataSeed.GetUserProjects());

            base.OnModelCreating(modelBuilder);
        }
    }
}
