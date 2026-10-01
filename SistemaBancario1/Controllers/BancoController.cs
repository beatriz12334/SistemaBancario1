using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario1.Controllers
{
    public class BancoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
