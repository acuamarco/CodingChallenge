using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Repository.Tests.Helpers;
using CodingChallenge.Repository.Repos;
using System.Linq;

namespace CodingChallenge.Repository.Tests.Repos
{
    [TestClass]
    public class UserProjectRepositoryTests : BaseDataTest
    {
        [TestMethod]
        public void ShouldGetUserProjectsByUserIdTest()
        {
            var repo = new UserProjectRepository(Db);
            Assert.AreEqual(3, repo.GetByUserId(1).ToList().Count);
            Assert.AreEqual(2, repo.GetByUserId(2).ToList().Count);
            var userProjects = repo.GetByUserId(3).ToList();
            Assert.AreEqual(2, userProjects.Count);
            Assert.IsNotNull(userProjects[0].Project, "Project information should be loaded");
        }
    }
}
