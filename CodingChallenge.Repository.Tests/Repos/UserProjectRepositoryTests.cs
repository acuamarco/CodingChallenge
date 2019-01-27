using NUnit.Framework;
using CodingChallenge.Repository.Tests.Helpers;
using CodingChallenge.Repository.Repos;
using System.Linq;

namespace CodingChallenge.Repository.Tests.Repos
{
    public class UserProjectRepositoryTests
    {
        private CodingChallengeContext context;

        [SetUp]
        public void Initialize()
        {
            context = ContextFactory.CreateContext();
        }

        [TearDown]
        public void Cleanup()
        {
            context.Dispose();
            context = null;
        }

        [Test]
        public void ShouldGetUserProjectsByUserIdTest()
        {
            var repo = new UserProjectRepository(context);
            Assert.AreEqual(3, repo.GetByUserId(1).ToList().Count);
            Assert.AreEqual(2, repo.GetByUserId(2).ToList().Count);
            var userProjects = repo.GetByUserId(3).ToList();
            Assert.AreEqual(2, userProjects.Count);
            Assert.IsNotNull(userProjects[0].Project, "Project information should be loaded");
        }
    }
}
