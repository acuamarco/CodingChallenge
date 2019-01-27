using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Repository.Repos
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
        where T : class, new()
    {
        protected CodingChallengeContext DbContext { get; set; }

        public IQueryable<T> Query()
        {
            return DbContext.Set<T>().AsQueryable();
        }
    }
}
