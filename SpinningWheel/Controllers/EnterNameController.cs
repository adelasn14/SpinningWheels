using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpinningWheel.Data;
using SpinningWheel.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpinningWheel.Controllers
{
    public class EnterNameController : Controller
    {
        private readonly SpinWheelDbContext _context;
        private readonly ILogger<EnterNameController> _logger;
        public EnterNameController(SpinWheelDbContext context, ILogger<EnterNameController> logger)
        {
            _context = context;
            _logger = logger;

        }
        // GET: /<controller>/
        [HttpPost]
        public async Task<IActionResult> Index([Bind("Id, Name, CreatedDateTime")] User user)
        {

            user.CreatedDateTime = DateTime.Now;

            _context.Add(user);
            await _context.SaveChangesAsync();

            MainController.ResetVideoWatched();

            return RedirectToAction("Index", "Main");
        }

        [HttpGet]
        public IActionResult Index()
        {
            MainController.ResetVideoWatched();
            return View();

        }
    }
}

