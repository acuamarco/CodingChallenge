using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Repository
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> Query();

        Task InsertAsync(T entity);

        Task UpdateAsync(T entity);
    }
}
