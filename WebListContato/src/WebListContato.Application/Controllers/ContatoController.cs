using Microsoft.AspNetCore.Mvc;

namespace WebListContato.Application.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
