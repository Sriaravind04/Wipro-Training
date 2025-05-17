using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    interface ISupportTicket
    {
        public void CreateTicket(string issue);
        public void ResolveTicket(int ticketId);
    }
    class EmailSupport : ISupportTicket {
        public void CreateTicket(string issue) {
            Console.WriteLine($"Creating ticket via Email: {issue}");
        }
        public void ResolveTicket(int ticketId) { Console.WriteLine($"Resolving ticket {ticketId} via Email");
        }
    }
        class PhoneSupport : ISupportTicket {
        public void CreateTicket(string issue) { Console.WriteLine($"Creating ticket via Phone: {issue}"); }
            
            public void ResolveTicket(int ticketId) {
                    Console.WriteLine($"Resolving ticket {ticketId} via Phone");
                }
        }
    class Program1
    {
        static void Main()
        {
            EmailSupport email = new EmailSupport();

            email.CreateTicket("sri");
            email.ResolveTicket(11);

            PhoneSupport phone = new PhoneSupport();
            phone.CreateTicket("aravind");
            phone.ResolveTicket(2);
        }

    }
}