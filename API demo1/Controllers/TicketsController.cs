using API_demo1.Model;
using API_demo1.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_demo1.Controllers
{
    [Route("API/[Controller]")]
    [ApiController]
    public class TicketsController : Controller
    {
        [HttpGet]
        [Route("all")]
        public List<Ticket> Get()
        {
            return TicketService.GetAll ();
        }
        [HttpGet]
        [Route("Id")]

        public Ticket Get(int Id)
        {
            Ticket t = TicketService.Get(Id);
            return t;
        }
    }
}
