using Microsoft.AspNetCore.Mvc;

namespace Unidad6_Ejercicio1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
