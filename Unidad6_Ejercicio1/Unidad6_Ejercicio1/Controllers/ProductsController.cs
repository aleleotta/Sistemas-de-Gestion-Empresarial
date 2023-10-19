using Microsoft.AspNetCore.Mvc;

namespace Unidad6_Ejercicio1.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult ProductsList()
        {
            return View();
        }

    }
}
