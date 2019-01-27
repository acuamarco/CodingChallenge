using System.Collections.Generic;
using System.Threading.Tasks;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Services
{
    public interface IUserService : IGenericService<User>
    {
        Task<IList<User>> GetAll();
    }
}
