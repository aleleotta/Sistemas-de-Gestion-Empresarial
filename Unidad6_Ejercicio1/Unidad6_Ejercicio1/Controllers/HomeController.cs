using Microsoft.AspNetCore.Mvc;

namespace Unidad6_Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Alessandro";
        }

        public String lastName()
        {
            return "Leotta";
        }

        public IActionResult Hello()
        {
            return View();
        }

    }
}
