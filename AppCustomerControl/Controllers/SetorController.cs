using AppCustomerControl.BLL;
using AppCustomerControl.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace AppCustomerControl.Controllers
{
    public class SetorController : Controller
    {
        public INotyfService _notifyService { get; }
        public SetorController(INotyfService notifyService)
        {
            _notifyService = notifyService;
        }
        public IActionResult Index()
        {
            var list = SetorBLL.listaSetores();
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> ActionModalSetor(int? id)
        {
            var setor = (dynamic)null;
            
            if(id == null || id == 0)
            {
                setor = new Setor()
                {
                    id = null,
                    descricao = ""
                };
            }
            else
            {
                var list = SetorBLL.listaSetores();
                var listFiltrada = list.Where(x => x.id == id).FirstOrDefault();   

                setor = new Setor()
                {
                    id = listFiltrada.id,
                    descricao = listFiltrada.descricao
                };
            }
            return PartialView("_ModalSetor",setor);
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
                objSetor.data_cadastro = DateTime.Now;

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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            _notifyService.Success("Setor excluido com sucesso!");

            return RedirectToAction(nameof(Index));
        }
    }
}
