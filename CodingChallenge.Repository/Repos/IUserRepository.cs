using System.Linq;

namespace CodingChallenge.Repository.Repos
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
    }
}
