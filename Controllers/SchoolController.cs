using Microsoft.AspNetCore.Mvc;

namespace CoursePractice.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
