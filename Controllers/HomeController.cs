using HW4.Models;
using Microsoft.AspNetCore.Mvc;
namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
