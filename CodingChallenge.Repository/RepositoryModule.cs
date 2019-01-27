using CodingChallenge.Repository.Repos;
using Microsoft.Extensions.DependencyInjection;

namespace CodingChallenge.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserProjectRepository, UserProjectRepository>();
        }
    }
}
