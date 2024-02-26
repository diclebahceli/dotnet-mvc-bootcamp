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

        public IActionResult List(){
            var bootcamps = new List<Bootcamp>(){
            new(){
                Id = 1,
                Title = "Backend Bootcamp",
                Description = "Learn backend development with C# and .NET",
                Instructor = "Ahmet Kaya",
                ImageUrl = "1.jpg"
            },
            new(){
                Id = 2,
                Title = "Frontend Bootcamp",
                Description = "Learn frontend development with HTML, CSS and JavaScript",
                Instructor = "Mehmet Yilmaz",
                ImageUrl = "2.jpg"
            },
            new(){
                Id = 3,
                Title = "Fullstack Bootcamp",
                Description = "Learn fullstack development with C#, .NET, HTML, CSS and JavaScript",
                Instructor = "Ayşe Demir",
                ImageUrl = "3.jpg"
            }};
            return View(bootcamps);
        }
    }
}