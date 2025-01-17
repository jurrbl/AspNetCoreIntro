using AspNetCoreIntro.Models;
using AspNetCoreIntro.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

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


        public IActionResult NewUser()
        {
            return View();
        }


        public IActionResult AddUser()
        {
            string name = Request.Form["Name"].ToString();
            string surname = Request.Form["Surname"].ToString();
            DateTime dob = Convert.ToDateTime(Request.Form["DateOfBirth"]);
            string pob = Request.Form["PlaceOfBirth"].ToString();

            UserModel user = new UserModel(-1, name, surname, dob, pob);
            _usersService.AddUser(user);


            return RedirectToAction("Index");

        }

        public IActionResult DeleteUser(int id)
        {
            int deleted = _usersService.DeleteUsersById(id);
            return Content($"Utente Eliminato : {deleted}");
        }
    }
}
