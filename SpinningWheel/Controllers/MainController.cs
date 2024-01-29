using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpinningWheel.Data;
using SpinningWheel.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        // GET: /<controller>/
        private static int videoWatched = 0;

        [HttpGet]
        public ActionResult Index()
        {
            var lastUser = _context.User.OrderByDescending(u => u.Id).FirstOrDefault();
            var userCount = _context.User.Count();

            var main = new Main
            {
                user = lastUser,
                userCount = _context.User.Count(),
                videoWatched = videoWatched
            };

            Console.WriteLine(videoWatched);
            return View(main);

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

