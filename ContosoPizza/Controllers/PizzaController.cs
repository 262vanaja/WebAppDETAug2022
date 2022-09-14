using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
