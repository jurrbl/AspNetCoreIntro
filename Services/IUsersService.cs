using AspNetCoreIntro.Models;

namespace AspNetCoreIntro.Services
{
    public interface IUsersService
    {
        IEnumerable<UserModel> GetUsers();

        UserModel? GetUsersById(int id);

    }
}
