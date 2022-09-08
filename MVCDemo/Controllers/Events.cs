using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Xml;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EventsController1 : Controller
    {

        public List<Booking> events { get; set; }

        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = " ask CEO", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = " ask Culture ", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = " ask sports", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = " ask Indoor", EventDate = DateTime.Today, Qty = 10 });

            return View(events);
        }
        
    }
}
