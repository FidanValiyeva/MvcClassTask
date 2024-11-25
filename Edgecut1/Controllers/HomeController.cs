using Microsoft.AspNetCore.Mvc;

namespace Edgecut1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
