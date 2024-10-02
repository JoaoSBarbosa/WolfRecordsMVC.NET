using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WolfMVC.Models;

namespace WolfMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.Email = "contato.joao@email.com";
            model.Nome = "João Barbosa";
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
