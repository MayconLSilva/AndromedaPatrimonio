using Microsoft.AspNetCore.Mvc;

namespace AndromedaPatrimonio.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
