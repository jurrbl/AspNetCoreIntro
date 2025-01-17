using AspNetCoreIntro.Models;

namespace AspNetCoreIntro.Services
{
    public interface IUsersService
    {
        IEnumerable<UserModel> GetUsers();

        UserModel? GetUsersById(int id);
        UserModel? AddUser(UserModel user);

        int DeleteUsersById(int id);

    }
}
