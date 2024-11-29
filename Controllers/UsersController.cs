
using AspNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreIntro.Controllers

{
    public class UsersController : Controller
    {

        private List<UserModel> users = new List<UserModel>()
        {   new UserModel(1, "Paperino", "Paolino", new DateTime(1934,7,5), "San Francisco"),
            new UserModel(2, "Giuseppe", "Garibaldi", new DateTime(1934,7,5), "Fossano"),
            new UserModel(3, "Micheal", "Jordan", new DateTime(1934,7,5), "Savigliano"),
            new UserModel(4, "Kobe", "Bryant", new DateTime(1934,7,5), "Cuneo")

        };
        public IActionResult Index()
        {
            return View(users);
        }

        public IActionResult Detail(int id)
        {
            string message = message = $"Sono Detail E Ho Ricevuto id {id}";            

            if (id > 0 && id < users.Count)
            { 
                    message += $"\nL'utente richiesta è {users[id]}";
            }
            else
            {
                message += "Utente non trovato";
            }

            return Content(message);

        }

    }
}
