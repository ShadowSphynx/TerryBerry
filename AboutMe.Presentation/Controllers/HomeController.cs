using Microsoft.AspNetCore.Mvc;

namespace AboutMe.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string GetAboutMeData()
        {
            return "Test";
        }
    }
}
