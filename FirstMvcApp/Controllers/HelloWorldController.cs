using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dog = new()
            { Name = "Sif", Age = 5 };
            return View(dog);
        }
        public IActionResult Create()
        {
            return View();  
        }
        public string Hello()
        {
            return "Who is there?";
        }
    }
}
