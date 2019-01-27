using CodingChallenge.Repository.Model;

namespace CodingChallenge.Repository
{
    public interface IDataSeed
    {
        Project[] GetProjects();
        User[] GetUsers();
        UserProject[] GetUserProjects();
    }
}
