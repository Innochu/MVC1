using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class AdminTagController : Controller
    {
        [HttpGet] // by default the get moethod is already imbeded
        public IActionResult Add()  //Add action method
        {
            return View();
        }
    }
}
