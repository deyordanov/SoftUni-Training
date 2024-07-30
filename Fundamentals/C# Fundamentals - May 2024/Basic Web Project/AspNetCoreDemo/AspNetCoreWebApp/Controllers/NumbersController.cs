using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    public class NumbersController : Controller
    {
        public IActionResult NumbersFrom1ToN(int number)
        {
            return View(number);
        }
    }
}
