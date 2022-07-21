using Microsoft.AspNetCore.Mvc;
using CoursePractice.Models;
using System;

namespace CoursePractice.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new Escuela()
            {
                UniqueId = Guid.NewGuid().ToString(),
                AñoDeCreación = 2005,
                Nombre = "Platzi"
            };

            ViewBag.DinamicProp = "My name is jeff!";
            return View(school);
        }
    }
}
