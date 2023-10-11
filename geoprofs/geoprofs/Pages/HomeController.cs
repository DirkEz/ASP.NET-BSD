using Microsoft.AspNetCore.Mvc;

namespace geoprofs.Pages
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
