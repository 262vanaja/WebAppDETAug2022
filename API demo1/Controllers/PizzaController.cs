using API_demo1.Services;
using Microsoft.AspNetCore.Mvc;
using API_demo1.Model;
namespace API_demo1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
        PizzaService.GetAll();
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

    }
}
