using API_demo1.Model;

namespace API_demo1.Service
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static TicketService()
        {
            Tickets = new List<Ticket> {

            new Ticket { Id=1, BookedFor=" platinumPlius", Price = 5000,Qty=200},
            new Ticket { Id = 11, BookedFor = " platinumPlius", Price = 4000, Qty = 50 },
            new Ticket { Id = 12, BookedFor = " Platinum", Price = 3000, Qty = 40 },
            new Ticket { Id = 13, BookedFor = " Gold", Price = 2000, Qty = 300 },
            new Ticket { Id = 14, BookedFor = " Silver", Price = 1000, Qty = 200 },
            new Ticket { Id = 1, BookedFor = " General", Price = 500, Qty = 10 }
            };



        }
        public static List<Ticket> GetAll() => Tickets;
        public static Ticket Get(int Id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x =>x.Id == Id);
            return ticket;
        }


    }
}
