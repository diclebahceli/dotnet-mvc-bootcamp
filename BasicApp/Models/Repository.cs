using System.Data.SqlTypes;

namespace BasicApp.Models
{
    public class Repository
    {
        private static readonly List<Bootcamp> _bootcamp = new();

        static Repository()
        {
            _bootcamp = new List<Bootcamp>(){
                 new(){
                Id = 1,
                Title = "Backend Bootcamp",
                Description = "Learn backend development with C# and .NET",
                Instructor = "Ahmet Kaya",
                ImageUrl = "1.jpg",
                tag= new string[] {"web development","asp.net"},
                isActive =true,
                isHome = false

            },
            new(){
                Id = 2,
                Title = "Frontend Bootcamp",
                Description = "Learn frontend development with HTML, CSS and JavaScript",
                Instructor = "Mehmet Yilmaz",
                ImageUrl = "2.jpg",
                tag= new string[] {"html","css"},
                isActive =true,
                isHome = true
            },
            new(){
                Id = 3,
                Title = "Fullstack Bootcamp",
                Description = "Learn fullstack development with C#, .NET, HTML, CSS and JavaScript",
                Instructor = "Ayşe Demir",
                ImageUrl = "3.jpg",
                tag= new string[] {"game development","unity"},
                isActive =true,
                isHome = true
            }
            };
        }

        public static List<Bootcamp> Bootcamps { get { return _bootcamp; } }


        public static Bootcamp GetById(int id)
        {
            return _bootcamp.FirstOrDefault(b => b.Id == id);
        }


    }
}