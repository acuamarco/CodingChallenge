﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.Api.Models;

namespace CodingChallenge.Api.Tests.Models
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void TimeToStartInPastTest()
        {
            var project = new Project() { StartDate = DateTime.Now.AddDays(-5), AssignedDate = DateTime.Now };

            Assert.AreEqual("Started", project.TimeToStart);
        }

        [TestMethod]
        public void TimeToStartSameDayTest()
        {
            var project = new Project() { StartDate = DateTime.Now, AssignedDate = DateTime.Now };

            Assert.AreEqual("0", project.TimeToStart);
        }

        [TestMethod]
        public void TimeToStartInFutureTest()
        {
            var project = new Project() { StartDate = DateTime.Now.AddDays(3), AssignedDate = DateTime.Now };

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