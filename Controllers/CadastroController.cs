using Microsoft.AspNetCore.Mvc;

namespace WebAppBuscaCepV2.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
