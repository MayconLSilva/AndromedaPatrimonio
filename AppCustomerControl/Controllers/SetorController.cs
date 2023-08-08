using AppCustomerControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppCustomerControl.Controllers
{
    public class SetorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ActionModalSetor()
        {
            var setor = new Setor()
            {
                id = 0,
                descricao = ""
            };
            return PartialView("_ModalSetor", setor);
        }
    }
}
