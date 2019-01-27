using NUnit.Framework;
using CodingChallenge.Repository.Tests.Helpers;
using System.Linq;

namespace CodingChallenge.Repository.Tests
{
    public class ReadDataTest
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
        public void ShouldGetAllUsersTest()
        {
            var users = context.Users;
            Assert.AreEqual(3, users.ToList().Count);
        }

        [Test]
        public void ShouldGetAllProjectsTest()
        {
            var projects = context.Projects;
            Assert.AreEqual(5, projects.ToList().Count);
        }

        [Test]
        public void ShouldGetAllUserProjectsTest()
        {
            var projects = context.UserProjects;
            Assert.AreEqual(7, projects.ToList().Count);
        }
    }
}
