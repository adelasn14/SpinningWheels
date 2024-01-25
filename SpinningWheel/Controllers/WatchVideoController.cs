using Microsoft.AspNetCore.Mvc;

namespace SpinningWheel.Controllers
{
    public class WatchVideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
