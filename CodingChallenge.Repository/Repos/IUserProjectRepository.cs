using System.Linq;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Repos
{
    public interface IUserProjectRepository : IGenericRepository<UserProject>
    {
        IQueryable<UserProject> GetByUserId(int userId);
    }
}
