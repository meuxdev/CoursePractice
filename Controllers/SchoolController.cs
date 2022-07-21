using Microsoft.AspNetCore.Mvc;
using CoursePractice.Models;
using System;

namespace CoursePractice.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new School()
            {
                Name = "Random School",
                SchoolId = Guid.NewGuid().ToString(),
                FoundationYear = 2002
            };
            return View(school);
        }
    }
}
