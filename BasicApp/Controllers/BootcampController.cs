using Microsoft.AspNetCore.Mvc;
using BasicApp.Models;

namespace BasicApp.Controllers
{
    public class BootcampController : Controller
    {
        public IActionResult Index()
        {
            var bootcamp = new Bootcamp();
            bootcamp.Id = 1;
            bootcamp.Title = "Backend Bootcamp";
            bootcamp.Description = "Learn backend development with C# and .NET";
            bootcamp.Instructor = "Ahmet Kaya";
            bootcamp.ImageUrl = "2.jpg";
            return View(bootcamp);
        }

        public IActionResult List()
        {
            return View(Repository.Bootcamps);
        }

        public IActionResult Details(int id)
        {
            var bootcamp = Repository.GetById(id);
            return View(bootcamp);
        }
    }
}