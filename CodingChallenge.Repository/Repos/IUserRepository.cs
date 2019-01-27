using System.Linq;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Repos
{
    public interface IUserRepository : IGenericRepository<User>
    {
        IQueryable<User> GetAll();
    }
}
