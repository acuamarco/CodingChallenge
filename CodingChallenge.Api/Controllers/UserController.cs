using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CodingChallenge.Repository.Repos;
using CodingChallenge.Services;
using CodingChallenge.Api.Models;

namespace CodingChallenge.Api.Controllers
{
  public class UserController : ApiController
  {
    [ResponseType(typeof(List<User>))]
    public async Task<IHttpActionResult> Get()
    {
      var dbContext = new Repository.CodingChallengeContext();
      var userRepo = new UserRepository(dbContext);
      var userService = new UserService(userRepo);

      var repoUsers = await userService.GetAll();
      var webUsers = new List<User>();
      foreach (var repoUser in repoUsers)
      {
        webUsers.Add(new User() { Id = repoUser.Id, FirstName = repoUser.FirstName, LastName = repoUser.LastName });
      }
      return Ok(webUsers);
    }

    [ResponseType(typeof(List<Project>))]
    [Route("api/user/{userId}/projects")]
    public async Task<IHttpActionResult> GetProjects(int userId)
    {
      var dbContext = new Repository.CodingChallengeContext();
      var userProjectRepo = new UserProjectRepository(dbContext);
      var userProjectService = new UserProjectService(userProjectRepo);

      var repoUserProjects = await userProjectService.GetByUserId(userId);
      var webProjects = new List<Project>();
      foreach (var repoUserProject in repoUserProjects)
      {
        webProjects.Add(new Project()
        {
          Id = repoUserProject.ProjectId,
          StartDate = repoUserProject.Project.StartDate,
          AssignedDate = repoUserProject.AssignedDate,
          EndDate = repoUserProject.Project.EndDate,
          Credits = repoUserProject.Project.Credits,
          IsActive = repoUserProject.IsActive
        });
      }
      return Ok(webProjects);
    }
  }
}
