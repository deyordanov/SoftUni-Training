using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Courses coursesDatabase = new Courses();

            List<Course> courses = coursesDatabase.GetCourses();

            return View(courses);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
