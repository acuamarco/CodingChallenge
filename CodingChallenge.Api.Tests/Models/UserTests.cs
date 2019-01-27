using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Api.Models;

namespace CodingChallenge.Api.Tests.Models
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void FirstNameNullShouldReturnEmptyStringTest()
        {
            var user = new User() { FirstName = null };

            Assert.AreEqual(string.Empty, user.FirstName);
        }

        [TestMethod]
        public void FirstNameShouldReturnTrimmedTest()
        {
            var user = new User() { FirstName = " first " };

            Assert.AreEqual("first", user.FirstName);
        }

        [TestMethod]
        public void LastNameNullShouldReturnEmptyStringTest()
        {
            var user = new User() { LastName = null };

            Assert.AreEqual(string.Empty, user.LastName);
        }

        [TestMethod]
        public void LastNameShouldReturnTrimmedTest()
        {
            var user = new User() { LastName = " last " };

            Assert.AreEqual("last", user.LastName);
        }

        [TestMethod]
        public void NameShouldConcatenateFirstAndLastTest()
        {
            var user = new User() {FirstName = " first ", LastName = " last "};

            Assert.AreEqual("first last", user.Name);
        }
    }
}
