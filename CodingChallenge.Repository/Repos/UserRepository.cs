using System.Linq;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Repos
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CodingChallengeContext dbContext)
        {
            DbContext = dbContext;
        }

        public IQueryable<User> GetAll()
        {
            return DbContext.Users.AsQueryable();
        }
    }
}
