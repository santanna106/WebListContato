using Microsoft.AspNetCore.Mvc;
using WebListContato.Domain.ViewModels;

namespace WebListContato.Application.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UsuarioViewModel usuarioViewModel)
        {
            
            if(!ModelState.IsValid) return View(usuarioViewModel);

            return RedirectToAction("Index");
        }
    }
}
