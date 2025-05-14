using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string  Index()
        {
            return "this is Employee Controller";
        }
        public string FirstName() {
            return "My firstName is Sri ";
        }
        public string LastName() {
            return "My LastName is Aravind";
        }
    }
}