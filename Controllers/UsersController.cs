using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreIntro.Controllers

{
    public class UsersController : Controller
    {

        private List<string> users = new List<string>()
        { "Paperino", "Pluto", "Topolino", "Minnie"};

        public IActionResult Index()
        {
            string listToPrint = string.Join(" \n", users);

            return Content("<< Elenco Studenti >> \n" +listToPrint);    
        }

        public IActionResult Detail(int id)
        {
            string message = $"Sono Detail E Ho Ricevuto id :  {id}";
            message += $"\nL'utente richiesta è {users[id]}";
            return Content(message);

        }

    }
}
