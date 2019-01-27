using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Repository.Tests.Helpers;
using System.Linq;

namespace CodingChallenge.Repository.Tests
{
    [TestClass]
    public class ReadDataTest : BaseTest
    {

        public ReadDataTest()
        {
        }

        [TestMethod]
        public void ShouldGetAllUsers()
        {
            var users = Db.Users;
            Assert.AreEqual(3, users.ToList().Count);
        }

        [TestMethod]
        public void ShouldGetAllProjects()
        {
            var projects = Db.Projects;
            Assert.AreEqual(5, projects.ToList().Count);
        }

        [TestMethod]
        public void ShouldGetAllUserProjects()
        {
            var projects = Db.UserProjects;
            Assert.AreEqual(6, projects.ToList().Count);
        }
    }
}
