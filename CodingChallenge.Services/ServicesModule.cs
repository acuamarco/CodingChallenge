using Microsoft.Extensions.DependencyInjection;

namespace CodingChallenge.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserProjectService, UserProjectService>();
        }
    }
}
