using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Repository.Tests.Helpers;
using System.Linq;

namespace CodingChallenge.Repository.Tests
{
    [TestClass]
    public class ReadDataTest : BaseDataTest
    {

        [TestMethod]
        public void ShouldGetAllUsersTest()
        {
            var users = Db.Users;
            Assert.AreEqual(3, users.ToList().Count);
        }

        [TestMethod]
        public void ShouldGetAllProjectsTest()
        {
            var projects = Db.Projects;
            Assert.AreEqual(5, projects.ToList().Count);
        }

        [TestMethod]
        public void ShouldGetAllUserProjectsTest()
        {
            var projects = Db.UserProjects;
            Assert.AreEqual(7, projects.ToList().Count);
        }
    }
}
