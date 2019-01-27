using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Repository.Tests.Helpers;
using CodingChallenge.Repository.Repos;
using System.Linq;

namespace CodingChallenge.Repository.Tests.Repos
{
    [TestClass]
    public class UserRepositoryTests : BaseDataTest
    {
        [TestMethod]
        public void ShouldGetAllUsersTest()
        {
            var userRepo = new UserRepository(Db);
            Assert.AreEqual(3, userRepo.GetAll().ToList().Count);
        }
    }
}
