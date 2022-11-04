using Microsoft.AspNetCore.Mvc;

namespace Ogani.WebUI.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
