using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Repository.Repos
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> Query();
    }
}
