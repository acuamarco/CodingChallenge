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

        public async Task InsertAsync(T entity)
        {
            DbContext.Set<T>().Add(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            DbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }
    }

}
