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

        [HttpPost]
        public async Task<IActionResult> ActionSalvaAtualiza(Setor objSetor)
        {
            if(objSetor.id == 0)
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return BadRequest(ModelState);
                }
                
            }
            else
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
        }

    }
}
