using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPL_EventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        public void OnGet()
        {
            Tickets= new List<Ticket>
            {
                new Ticket{ Category="PlatinnumPlus", Price=5000 ,MaxLimit=2000000},
                new Ticket{ Category="Platinum", Price=4000 ,MaxLimit=2000000},
                new Ticket{ Category="gold", Price=3000 ,MaxLimit=2000000},
                new Ticket{ Category="Sliver", Price=2000,MaxLimit=2000000},
                new Ticket{ Category="General", Price=1000 ,MaxLimit=2000000},
             };



        }
    }
}
