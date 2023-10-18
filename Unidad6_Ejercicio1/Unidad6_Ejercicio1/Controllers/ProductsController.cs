using Microsoft.AspNetCore.Mvc;

namespace Unidad6_Ejercicio1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
