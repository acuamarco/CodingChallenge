using Microsoft.EntityFrameworkCore;

namespace CodingChallenge.Repository.Tests.Helpers
{
    public static class ContextFactory
    {
        public static CodingChallengeContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<CodingChallengeContext>()
                .UseInMemoryDatabase("ExchangeUnitTestsDb")
                .Options;
            var context = new CodingChallengeContext(options, new DataSeed());
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            return context;
        }
    }
}
