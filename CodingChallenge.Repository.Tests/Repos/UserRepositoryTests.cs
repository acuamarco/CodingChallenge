using NUnit.Framework;
using CodingChallenge.Repository.Tests.Helpers;
using CodingChallenge.Repository.Repos;
using System.Linq;

namespace CodingChallenge.Repository.Tests.Repos
{
    public class UserRepositoryTests
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
            var userRepo = new UserRepository(context);
            Assert.AreEqual(3, userRepo.GetAll().ToList().Count);
        }
    }
}
