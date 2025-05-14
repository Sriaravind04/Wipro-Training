using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "this is INDEX";
        }
        public string GetStudentName() {
            return "Name : SRI ARAVIND";
        }
        public string GetStudentPhone() {
            return "PH NO : 7708689149";
        }
    }
}