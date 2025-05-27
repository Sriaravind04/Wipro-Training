using Microsoft.AspNetCore.Mvc;

namespace WebApplication13.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
