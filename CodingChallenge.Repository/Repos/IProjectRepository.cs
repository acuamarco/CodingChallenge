using System.Linq;

namespace CodingChallenge.Repository.Repos
{
    public interface IProjectRepository
    {
        IQueryable<Project> GetByUserId(int userId);
    }
}
