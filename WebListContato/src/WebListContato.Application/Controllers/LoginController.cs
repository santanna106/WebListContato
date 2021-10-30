using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
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

            if ("usr1" == usuarioViewModel.Login && "123456"== usuarioViewModel.Senha)
            {
                var userClaims = new List<Claim>()
                {
                    //define o cookie
                    new Claim(ClaimTypes.Name, usuarioViewModel.Login),
                    new Claim(ClaimTypes.Email, "macoratti@teste.com"),
                };
                var minhaIdentity = new ClaimsIdentity(userClaims, "Usuario");
                var userPrincipal = new ClaimsPrincipal(new[] { minhaIdentity });
                //cria o cookie
                HttpContext.SignInAsync(userPrincipal);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Message = "Credenciais inválidas...";
            return View(usuarioViewModel);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
