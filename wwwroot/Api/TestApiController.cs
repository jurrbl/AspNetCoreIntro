using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.wwwroot.Api
{
    [ApiController]
    [Route("api/[controller]")]


    // [Route("api/[controller]/[action]")] se voglio cambiare nome sotto e tenere qualcosa di diverso da Get() 
    public class TestApiController : ControllerBase //Controlli Semplificati
    {
        public IActionResult Get() //Con la GET Prende in automatico 
        {
            var pet = new { Age = 44, Name = "Mary" };
            return Ok(pet);
        }


    }
}
