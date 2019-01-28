using NUnit.Framework;
using CodingChallenge.Api.Models;

namespace CodingChallenge.Api.Tests.Models
{
    public class UserTests
    {
        [Test]
        public void FirstNameNullShouldReturnEmptyStringTest()
        {
            var user = new User() { FirstName = null };

            Assert.AreEqual(string.Empty, user.FirstName);
        }

        [Test]
        public void FirstNameShouldReturnTrimmedTest()
        {
            var user = new User() { FirstName = " first " };

            Assert.AreEqual("first", user.FirstName);
        }

        [Test]
        public void LastNameNullShouldReturnEmptyStringTest()
        {
            var user = new User() { LastName = null };

            Assert.AreEqual(string.Empty, user.LastName);
        }

        [Test]
        public void LastNameShouldReturnTrimmedTest()
        {
            var user = new User() { LastName = " last " };

            Assert.AreEqual("last", user.LastName);
        }

        [Test]
        public void NameShouldConcatenateFirstAndLastTest()
        {
            var user = new User() {FirstName = " first ", LastName = " last "};

            Assert.AreEqual("first last", user.Name);
        }
    }
}
