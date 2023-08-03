using AppCustomerControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppCustomerControl.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var usuario = new User()
            {
                id = 1,
                nome = "Maycon Silva",
                login = "maycon",
                password = "123456"
            };
            return View(usuario);
        }

        public async Task<IActionResult> Ativar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            
             return View("UsuarioAtivado");
        }
    }
}
