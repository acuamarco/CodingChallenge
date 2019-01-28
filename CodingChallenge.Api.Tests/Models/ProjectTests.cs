using System;
using CodingChallenge.Api.Models;
using NUnit.Framework;

namespace CodingChallenge.Api.Tests.Models
{
    public class ProjectTests
    {
        [Test]
        public void TimeToStartInPastTest()
        {
            var date = DateTime.Now;
            var project = new Project() { StartDate = date.AddDays(-5), AssignedDate = date };

            Assert.AreEqual("Started", project.TimeToStart);
        }

        [Test]
        public void TimeToStartSameDayTest()
        {
            var date = DateTime.Now;
            var project = new Project() { StartDate = date, AssignedDate = date };

            Assert.AreEqual("0", project.TimeToStart);
        }

        [Test]
        public void TimeToStartInFutureTest()
        {
            var date = DateTime.Now;
            var project = new Project() { StartDate = date.AddDays(3), AssignedDate = date };

            Assert.AreEqual("3", project.TimeToStart);
        }

        [Test]
        public void IsActiveTest()
        {
            var project = new Project() { IsActive = true };

            Assert.AreEqual("Active", project.Status);
        }

        [Test]
        public void IsInactiveTest()
        {
            var project = new Project() { IsActive = false };

            Assert.AreEqual("Inactive", project.Status);
        }
    }
}
