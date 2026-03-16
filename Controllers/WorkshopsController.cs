using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab3.Data;
using Lab3.Models;
using System.Threading.Tasks;
using System.Linq;

namespace Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkshopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Display the registration form
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: Process the registration form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Rsvp rsvp)
        {
            if (ModelState.IsValid)
            {
                // For Lab 4, we're NOT saving to database
                return RedirectToAction("Confirmation", rsvp);
            }
            return View(rsvp);
        }

        // GET: Show confirmation
        public IActionResult Confirmation(Rsvp rsvp)
        {
            return View(rsvp);
        }

        // GET: Show all registrations from database
        public async Task<IActionResult> Registrations()
        {
            var rsvps = await _context.Rsvps.ToListAsync();
            return View(rsvps);
        }
    }
}