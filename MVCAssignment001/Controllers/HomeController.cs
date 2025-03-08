using Microsoft.AspNetCore.Mvc;

namespace MVCAssignment001.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
           
            return View("Index");
            
        }

        public IActionResult AboutUs()
        {

            return View();

        }

        public IActionResult Privacy()
        {

            return View();

        }
    }
}
