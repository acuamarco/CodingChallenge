using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodingChallenge.Services;
using CodingChallenge.Api.Models;
using Microsoft.AspNetCore.Cors;

namespace CodingChallenge.Api.Controllers
{
    [Route("api")]
    [EnableCors("CorsPolicy")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IUserProjectService userProjectService;

        public UserController(IUserService userService, IUserProjectService userProjectService)
        {
            this.userService = userService;
            this.userProjectService = userProjectService;
        }

        [HttpGet("user")]
        public async Task<IActionResult> GetUsers()
        {
            var repoUsers = await userService.GetAll();
            var webUsers = new List<User>();
            foreach (var repoUser in repoUsers)
            {
                webUsers.Add(new User() { Id = repoUser.Id, FirstName = repoUser.FirstName, LastName = repoUser.LastName });
            }
            return Ok(webUsers);
        }
        
        [HttpGet("user/{userId}/projects")]
        public async Task<IActionResult> GetProjects(int userId)
        {
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
