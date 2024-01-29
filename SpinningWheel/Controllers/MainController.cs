using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpinningWheel.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
        private static int videoWatched = 0;

        public ActionResult Index()
        {

            Console.WriteLine(videoWatched);
            return View(videoWatched);
        }

        [HttpPost]
        public ActionResult IncrementIndex()
        {
            videoWatched++;
            Console.WriteLine("hit api");

            return RedirectToAction("Index");
        }

        public static void ResetVideoWatched()
        {
            videoWatched = 0;
        }



        public IActionResult Automation()
        {
            return View();
        }

        public IActionResult MultisourceMaterial()
        {
            return View();
        }

        public IActionResult VAVE()
        {
            return View();
        }

        public IActionResult ReduceRejection()
        {
            return View();
        }

        public IActionResult JobBalancing()
        {
            return View();
        }

        public IActionResult IncreaseProductivity()
        {
            return View();
        }
    }
}

