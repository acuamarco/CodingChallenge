using System.Linq;
using System.Data.Entity;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Repos
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(CodingChallengeContext dbContext)
        {
            DbContext = dbContext;
        }

        public IQueryable<Project> GetByUserId(int userId)
        {
            return DbContext.UserProjects
                .Include(up => up.Project)
                .Where(up => up.UserId == userId)
                .Select(up => up.Project)
                .AsQueryable();
        }
    }
}
