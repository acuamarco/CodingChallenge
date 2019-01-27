using System;
using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository.Tests.Helpers
{
    public static class AddRecords
    {
        public static void AddUser(CodingChallengeContext db, User u)
        {
            db.Database.ExecuteSqlCommand($"INSERT INTO [dbo].[User] (FirstName, LastName) VALUES ('{u.FirstName}', '{u.LastName}')");
        }

        public static void AddProject(CodingChallengeContext db, Project p)
        {
            db.Database.ExecuteSqlCommand($"INSERT INTO [dbo].[Project] ([StartDate], [EndDate] ,[Credits]) VALUES ('{p.StartDate}', '{p.EndDate}' , {p.Credits})");
        }

        public static void AddUserProject(CodingChallengeContext db, UserProject up)
        {
            var active = up.IsActive ? 1 : 0;
            db.Database.ExecuteSqlCommand($"INSERT INTO [dbo].[UserProject] ([UserId], [ProjectId], [IsActive] ,[AssignedDate]) VALUES ({up.UserId}, {up.ProjectId}, {active}, '{up.AssignedDate}')");
        }

        public static void SeedTestData(CodingChallengeContext Db)
        {
            AddUser(Db, new User() { FirstName = "FirstName 1", LastName = "LastName 1" });
            AddUser(Db, new User() { FirstName = "FirstName 2", LastName = "LastName 2" });
            AddUser(Db, new User() { FirstName = "FirstName 3", LastName = "LastName 3" });


            AddProject(Db, new Project() { StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Credits = 1 });
            AddProject(Db, new Project() { StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2), Credits = 2 });
            AddProject(Db, new Project() { StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), Credits = 3 });
            AddProject(Db, new Project() { StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(4), Credits = 4 });
            AddProject(Db, new Project() { StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5), Credits = 5 });

            AddUserProject(Db, new UserProject() { UserId = 1, ProjectId = 1, AssignedDate = DateTime.Now, IsActive = true });
            AddUserProject(Db, new UserProject() { UserId = 1, ProjectId = 2, AssignedDate = DateTime.Now, IsActive = false });
            AddUserProject(Db, new UserProject() { UserId = 1, ProjectId = 5, AssignedDate = DateTime.Now, IsActive = false });
            AddUserProject(Db, new UserProject() { UserId = 2, ProjectId = 3, AssignedDate = DateTime.Now, IsActive = true });
            AddUserProject(Db, new UserProject() { UserId = 2, ProjectId = 4, AssignedDate = DateTime.Now, IsActive = false });
            AddUserProject(Db, new UserProject() { UserId = 3, ProjectId = 1, AssignedDate = DateTime.Now, IsActive = true });
            AddUserProject(Db, new UserProject() { UserId = 3, ProjectId = 5, AssignedDate = DateTime.Now, IsActive = true });
        }
    }
}
