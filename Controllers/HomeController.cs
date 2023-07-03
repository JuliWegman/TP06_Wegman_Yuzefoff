using Microsoft.AspNetCore.Mvc;

namespace TP 06 - Elecciones.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
