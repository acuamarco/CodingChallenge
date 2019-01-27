using CodingChallenge.Repository.Repos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CodingChallenge.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<CodingChallengeContext>(options => options.UseSqlServer(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserProjectRepository, UserProjectRepository>();
        }
    }
}
