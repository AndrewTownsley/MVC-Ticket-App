using Microsoft.AspNetCore.Mvc;

namespace MVC_PracticeAppMOnday.Controllers
{
    public class ExampleController : Controller
    {

        public string Index()
        {
            return "This is an example of returning a string from the controller, WITHOUT a view";
        }

        public string Hello()
        {
            return "Anther controler action that returns a string... NO VIEW FILE";
        }
       /* public IActionResult Index()
        {
            return View();
        }*/
    }
}
