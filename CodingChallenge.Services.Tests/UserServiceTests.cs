using Moq;
using NUnit.Framework;
using CodingChallenge.Repository.Repos;
using CodingChallenge.Repository.Model;
using CodingChallenge.Services.Tests.Helpers;
using System;
using System.Threading.Tasks;

namespace CodingChallenge.Services.Tests
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepository> userRepoMock = new Mock<IUserRepository>();
        private readonly Mock<IUserProjectRepository> userProjectRepoMock = new Mock<IUserProjectRepository>();

        [Test]
        public async Task ShouldGetAllUsers()
        {
            var users = new[]
            {
                new User() { Id = 1, FirstName = "User", LastName ="1"},
                new User() { Id = 2, FirstName = "User", LastName ="2"},
                new User() { Id = 3, FirstName = "User", LastName ="3"},
                new User() { Id = 4, FirstName = "User", LastName ="4"},
                new User() { Id = 5, FirstName = "User", LastName ="5"}
            };


            userRepoMock
                .Setup(mock => mock.GetAll())
                .Returns(new AsyncQueryResult<User>(users));

            var service = new UserService(userRepoMock.Object);

            var result = await service.GetAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count);
        }

        [Test]
        public async Task ShouldGetUserProjects()
        {
            var userProjects = new[]
            {
                new UserProject() {
                    ProjectId = 1, AssignedDate= DateTime.Now, IsActive = false,
                    Project = new Repository.Model.Project() {
                        Id = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Credits = 1
                    }
                }
            };

            userProjectRepoMock
               .Setup(mock => mock.GetByUserId(It.IsAny<int>()))
               .Returns(new AsyncQueryResult<UserProject>(userProjects));

            var service = new UserProjectService(userProjectRepoMock.Object);

            var result = await service.GetByUserId(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
    }
}
