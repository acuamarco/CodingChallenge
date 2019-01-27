using CodingChallenge.Repository.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingChallenge.Services
{
    public interface IUserProjectService : IGenericService<UserProject>
    {
        Task<IList<UserProject>> GetByUserId(int userId);
    }
}
