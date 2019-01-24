using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CodingChallenge.Web.Models;

namespace CodingChallenge.Web.Controllers
{
    public class UserController : ApiController
    {
        [ResponseType(typeof(List<User>))]
        public async Task<IHttpActionResult> Get()
        {
            var users = await GetUsers();
            return Ok(users);
        }

        private async Task<IEnumerable<User>> GetUsers()
        {
            return await Task.FromResult(new List<User>()
            {
                new User() { Id = 1, FirstName = "User", LastName = "1" },
                new User() { Id = 1, FirstName = "User", LastName = "2" }
            });
        }
    }
}