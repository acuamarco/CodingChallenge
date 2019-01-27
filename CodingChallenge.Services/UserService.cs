using CodingChallenge.Repository.Model;
using CodingChallenge.Repository.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodingChallenge.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IUserRepository repo) : base(repo)
        {
        }

        public async Task<IList<User>> GetAll()
        {
            return await (Repository as IUserRepository).GetAll().ToListAsync();
        }
    }
}
