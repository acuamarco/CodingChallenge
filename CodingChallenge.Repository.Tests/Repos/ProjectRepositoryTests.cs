using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Repository.Tests.Helpers;
using CodingChallenge.Repository.Repos;
using System.Linq;

namespace CodingChallenge.Repository.Tests.Repos
{
    [TestClass]
    public class ProjectRepositoryTests : BaseDataTest
    {
        [TestMethod]
        public void ShouldGetProjectsByUserIdTest()
        {
            var repo = new ProjectRepository(Db);
            Assert.AreEqual(3, repo.GetByUserId(1).ToList().Count);
            Assert.AreEqual(2, repo.GetByUserId(2).ToList().Count);
            Assert.AreEqual(2, repo.GetByUserId(3).ToList().Count);
        }
    }
}
