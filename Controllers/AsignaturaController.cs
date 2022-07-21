using System;
using Microsoft.AspNetCore.Mvc;
using CoursePractice.Models;

namespace CoursePractice.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var assingment = new Asignatura()
            {
                Nombre = "Math",
                UniqueId = Guid.NewGuid().ToString(),
            };
            return View(assingment);
        }
    }
}
