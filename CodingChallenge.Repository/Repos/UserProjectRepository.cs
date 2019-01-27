using System.Linq;
using System.Data.Entity;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Repos
{
    public class UserProjectRepository : GenericRepository<UserProject>, IUserProjectRepository
    {
        public UserProjectRepository(CodingChallengeContext dbContext)
        {
            DbContext = dbContext;
        }

        public IQueryable<UserProject> GetByUserId(int userId)
        {
            return DbContext.UserProjects
                .Include(up => up.Project)
                .Where(up => up.UserId == userId)
                .AsQueryable();
        }
    }
}
