using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is the index page!";
        }
        public string Hello()
        {
            return "Who is there?";
        }
    }
}
