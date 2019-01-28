using NUnit.Framework;
using CodingChallenge.Api.Controllers;
using Moq;
using CodingChallenge.Services;
using CodingChallenge.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CodingChallenge.Api.Tests.Controllers
{
    public class UserControllerTests
    {

        [Test]
        public async Task GetUsersTest()
        {
            var userServiceMock = new Mock<IUserService>();
            var users = new List<Repository.Model.User>()
            {
                new Repository.Model.User() {FirstName = "User 1"},
                new Repository.Model.User() {FirstName = "User 2"}
            };
            userServiceMock.Setup(s => s.GetAll()).Returns(Task.FromResult<IList<Repository.Model.User>>(users));
            
            var controller = new UserController(userServiceMock.Object, null);

            var r = await controller.GetUsers();
            var result = (r as OkObjectResult).Value as List<User>;

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public async Task GetProjectsTest()
        {
            var userProjectServiceMock = new Mock<IUserProjectService>();
            var userProjects = new List<Repository.Model.UserProject>()
            {
                new Repository.Model.UserProject() {
                    ProjectId = 1, AssignedDate= DateTime.Now, IsActive = false,
                    Project = new Repository.Model.Project() {
                        Id = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Credits = 1
                    }
                }
            };
            

            userProjectServiceMock.Setup(s => s.GetByUserId(It.IsAny<int>())).Returns(
                Task.FromResult<IList<Repository.Model.UserProject>>(userProjects)
            );
            var controller = new UserController(null, userProjectServiceMock.Object);

            var r = await controller.GetProjects(1);
            var result = (r as OkObjectResult).Value as List<Project>;

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(1, result[0].Credits);
        }
    }
}
