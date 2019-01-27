using System;

namespace CodingChallenge.Repository.Tests.Helpers
{
    public class BaseDataTest : IDisposable
    {
        protected readonly CodingChallengeContext Db;

        public BaseDataTest()
        {
            Db = new CodingChallengeContext();
            Reset();
            AddRecords.SeedTestData(Db);
        }

        public void Dispose()
        {
            Reset();
        }

        private void Reset()
        {
            Db.Database.ExecuteSqlCommand("delete from [dbo].[UserProject]");
            Db.Database.ExecuteSqlCommand("delete from [dbo].[User]");
            Db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('[dbo].[User]', RESEED, 0)");
            Db.Database.ExecuteSqlCommand("delete from [dbo].[Project]");
            Db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('[dbo].[Project]', RESEED, 0)");
        }
    }
}
