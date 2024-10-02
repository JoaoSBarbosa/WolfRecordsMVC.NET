using Microsoft.AspNetCore.Mvc;

namespace WolfMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
