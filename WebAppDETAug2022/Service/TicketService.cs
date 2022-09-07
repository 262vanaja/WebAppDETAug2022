//using Microsoft.AspNetCore.Authentication;
//using System.Xml.Linq;
//using WebAppDETAug2022.Models;
//namespace WebAppDETAug2022.Service
//{
//    public class TicketService
//    {
//        static List<Ticket> Tickets { get; }
//        static int nextId = 2;
//        static TicketService()
//        {
//            Tickets = new List<Ticket>
//                {
//                        new Ticket { Id = 1, Catageroy = "abc", Price  =20 },
//                        new Ticket {  Id = 2, Catageroy = "bcd", Price = 15 }
//                };
//        }

//        public static List<Ticket> GetAll() => Tickets;

//        public static Ticket Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

//        public static void Add(Ticket ticket)
//        {
//            Tickets.Id = nextId++;
//            Tickets.Add(Tickets);
//        }

//        //public static void Delete(int id)
//        //{
//        //    var Ticket = Get(id);
//        //    if (Ticket is null)
//        //        return;

//        //    Tickets.Remove(Ticket);
//        //}

//        //public static void Update(Ticket Ticket)
//        //{
//        //    var index = Tickets.FindIndex(p => p.Id == Ticket.Id);
//        //    if (index == -1)
//        //        return;

//        //    Tickets[index] = Ticket;
//        //}
//    }
//}


