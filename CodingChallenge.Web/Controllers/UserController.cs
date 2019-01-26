using System;
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
      var users = await _GetUsers();
      return Ok(users);
    }

    [ResponseType(typeof(List<Project>))]
    [Route("api/user/{userId}/projects")]
    public async Task<IHttpActionResult> GetProjects(int userId)
    {
      var projects = await _GetProjects(userId);
      return Ok(projects);
    }

    private async Task<IEnumerable<User>> _GetUsers()
    {
      return await Task.FromResult(new List<User>()
            {
                new User() { Id = 1, FirstName = "User", LastName = "1" },
                new User() { Id = 1, FirstName = "User", LastName = "2" }
            });
    }

    private async Task<IEnumerable<Project>> _GetProjects(int userId)
    {
      return await Task.FromResult(new List<Project>()
      {
        new Project() {Id = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Credits = 1, IsActive = true }
      });
    }
  }
}
