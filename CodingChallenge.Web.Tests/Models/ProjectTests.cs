using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Web.Models;

namespace CodingChallenge.Web.Tests.Models
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void TimeToStartInPastTest()
        {
            var project = new Project() { StartDate = DateTime.Now.AddDays(-5) };

            Assert.AreEqual("Started", project.TimeToStart);
        }

        [TestMethod]
        public void TimeToStartSameDayTest()
        {
            var project = new Project() { StartDate = DateTime.Now };

            Assert.AreEqual("0", project.TimeToStart);
        }

        [TestMethod]
        public void TimeToStartInFutureTest()
        {
            var project = new Project() { StartDate = DateTime.Now.AddDays(3) };

            Assert.AreEqual("3", project.TimeToStart);
        }

        [TestMethod]
        public void IsActiveTest()
        {
            var project = new Project() { IsActive = true };

            Assert.AreEqual("Active", project.Status);
        }

        [TestMethod]
        public void IsInactiveTest()
        {
            var project = new Project() { IsActive = false };

            Assert.AreEqual("Inactive", project.Status);
        }
    }
}
