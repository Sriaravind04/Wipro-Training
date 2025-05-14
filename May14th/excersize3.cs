using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace ConsoleApp5
{
    abstract class TicketBooking {
        public abstract void BookTicket(int seats);
        public void ShowBookingInfo() { Console.WriteLine("Booking tickets");  }
    }
    class BusBooking : TicketBooking {
        public override void BookTicket(int seats)
        {
            Console.WriteLine("Booking "+seats+" bus tickets");

        }

    }
    class FlightBooking : TicketBooking {
        public override void BookTicket(int seats)
        {
            Console.WriteLine("Booking "+seats+" flight tickets");
        }
    }
    internal class Program2
    {
        static void Main(string[] args) {
            TicketBooking ticket1 = new BusBooking();
            ticket1.ShowBookingInfo();
            ticket1.BookTicket(1);

            TicketBooking ticket2 = new FlightBooking();
            ticket2.ShowBookingInfo();
            ticket2.BookTicket(2);
        }
    }
}