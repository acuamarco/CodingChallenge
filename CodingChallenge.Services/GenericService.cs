using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodingChallenge.Repository.Repos;


namespace CodingChallenge.Services
{
    public abstract class GenericService<T> : IGenericService<T>
        where T : class, new()
    {

        protected IGenericRepository<T> Repository { get; }

        protected GenericService(IGenericRepository<T> repo)
        {
            Repository = repo;
        }
    }
}
