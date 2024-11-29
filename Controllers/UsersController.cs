
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreIntro.Controllers

{
    public class UsersController : Controller
    {

        private List<string> users = new List<string>()
        { "Paperino", "Pluto", "Topolino", "Minnie"};

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
