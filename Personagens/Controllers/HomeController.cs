using Microsoft.AspNetCore.Mvc;
using Personagens.Models;
namespace Personagens.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
