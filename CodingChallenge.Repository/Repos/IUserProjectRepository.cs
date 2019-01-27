using System.Linq;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Repos
{
    public interface IUserProjectRepository : IGenericRepository<Project>
    {
        IQueryable<UserProject> GetByUserId(int userId);
    }
}
