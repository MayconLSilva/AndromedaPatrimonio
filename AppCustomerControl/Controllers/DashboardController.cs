using Microsoft.AspNetCore.Mvc;

namespace AppCustomerControl.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
