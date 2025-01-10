using AspNetCoreIntro.Models;
using AspNetCoreIntro.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        // Public constructor for DI
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            return View(_usersService.GetUsers());
        }

        public IActionResult Detail(int id)
        {
            //string message = $"Sono Detail E Ho Ricevuto id {id}";
            //UserModel? user = _usersService.GetUsersById(id);

            //if (user != null)
            //{
            //    message += $"\nL'utente richiesto è {user.Name}";
            //}
            //else
            //{
            //    message += "\nUtente non trovato";
            //}

            //return Content(message);

            return View(_usersService.GetUsersById(id));
        }


        public IActionResult DeleteUser(int id)
        {
            int deleted = _usersService.DeleteUserById(id);
            return Content($"Utente Eliminato : {deleted}");
        }
    }
}
