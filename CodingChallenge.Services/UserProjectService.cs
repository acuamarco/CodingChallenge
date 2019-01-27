using CodingChallenge.Repository.Model;
using CodingChallenge.Repository.Repos;
using System.Collections.Generic;
using System.Data.Entity;

using System.Threading.Tasks;

namespace CodingChallenge.Services
{
    public class UserProjectService : GenericService<UserProject>, IUserProjectService
    {
        public UserProjectService(IUserProjectRepository repo) : base(repo)
        {
        }

        public async Task<IList<UserProject>> GetByUserId(int userId)
        {
            return await(Repository as IUserProjectRepository).GetByUserId(userId).ToListAsync();
        }
    }
}
