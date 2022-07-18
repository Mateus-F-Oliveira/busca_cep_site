using Microsoft.AspNetCore.Mvc;

namespace WebAppBuscaCepV2.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}