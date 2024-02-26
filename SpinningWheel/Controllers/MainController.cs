using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpinningWheel.Data;
using SpinningWheel.Models;

namespace SpinningWheel.Controllers
{
    public class MainController : Controller
    {
        private readonly SpinWheelDbContext _context;
        private readonly ILogger<MainController> _logger;
        public MainController(SpinWheelDbContext context, ILogger<MainController> logger)
        {
            _context = context;
            _logger = logger;
        }

        private static int videoWatched = 0;

        [HttpGet]
        public ActionResult Index()
        {

            DateTime today = DateTime.Today;

            var lastUser = HttpContext.Session.GetString("Name") ?? "There" ;
            var records = _context.User
                .Where(u => u.CreatedDateTime.Date == today)
                .ToList();

            var main = new Main
            {
                user = lastUser,
                userCount = records.Count(),
                videoWatched = videoWatched
            };

            Console.WriteLine(videoWatched);
            return View(main);

        }

        [HttpPost]
        public IActionResult IncrementIndex(string pageIdentifier)
        {
            // Check if the page has been visited in the current session
            var visitedPages = HttpContext.Session.GetString("VisitedPages") ?? "";
            if (!visitedPages.Contains(pageIdentifier))
            {
                // Increment videoWatched
                videoWatched++;

                // Update visitedPages in session
                HttpContext.Session.SetString("VisitedPages", $"{visitedPages},{pageIdentifier}");
            }

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

        public IActionResult Summary()
        {
            return View();
        }

        public IActionResult IncreaseProductivity()
        {
            return View();
        }

        public ActionResult End()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("Name");

            return RedirectToAction("Index", "Home");
        }
    }
}

