using CodingChallenge.Repository;
using CodingChallenge.Repository.Model;
using System;

namespace CodingChallenge.Api
{
    public class DataSeed : IDataSeed
    {
        public Project[] GetProjects()
        {
            return new[] {
                new Project() { Id = 1,  StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Credits = 1 },
                new Project() { Id = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2), Credits = 2 },
                new Project() { Id = 3, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), Credits = 3 },
                new Project() { Id = 4, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(4), Credits = 4 },
                new Project() { Id = 5, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5), Credits = 5 }
            };
        }

        public UserProject[] GetUserProjects()
        {
            return new[] {
                new UserProject() { UserId = 1, ProjectId = 1, AssignedDate = DateTime.Now, IsActive = true },
                new UserProject() { UserId = 1, ProjectId = 2, AssignedDate = DateTime.Now, IsActive = false },
                new UserProject() { UserId = 1, ProjectId = 5, AssignedDate = DateTime.Now, IsActive = false },
                new UserProject() { UserId = 2, ProjectId = 3, AssignedDate = DateTime.Now, IsActive = true },
                new UserProject() { UserId = 2, ProjectId = 4, AssignedDate = DateTime.Now, IsActive = false },
                new UserProject() { UserId = 3, ProjectId = 1, AssignedDate = DateTime.Now, IsActive = true },
                new UserProject() { UserId = 3, ProjectId = 5, AssignedDate = DateTime.Now, IsActive = true }
            };
        }

        public User[] GetUsers()
        {
            return new[] {
                new User() { Id = 1, FirstName = "FirstName 1", LastName = "LastName 1" },
                new User() { Id = 2, FirstName = "FirstName 2", LastName = "LastName 2" },
                new User() { Id = 3, FirstName = "FirstName 3", LastName = "LastName 3" }
            };
        }
    }
}
