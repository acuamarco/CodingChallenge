using System.Linq;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Repos
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        IQueryable<Project> GetByUserId(int userId);
    }
}
