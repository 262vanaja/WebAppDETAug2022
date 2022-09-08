using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Service;
using System.Security.Cryptography.X509Certificates;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {

        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);

        }
        public IActionResult Detail(int id)
        {
            Pizza p = PizzaService.Get(id);
            return View(p);
        }
        public IActionResult List(int id)
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }
        public IActionResult Create()

        {
            return View();

        }
        [HttpPost]

        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }





        public IActionResult Delete( int Id)


        {
            Pizza p = PizzaService.Get(Id);
              if (p != null)

            return View(p);

            return RedirectToAction("List");
        }
        [HttpPost]

        public IActionResult Delete(Pizza p)
        {
            PizzaService.Delete(p.Id);
            return RedirectToAction("List");
        }
    }
}

    

        
        
    
