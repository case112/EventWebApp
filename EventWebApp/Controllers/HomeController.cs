using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventWebApp.Models;
using EventWebApp.Data;
using EventWebApp.Models.ViewModels;

namespace EventWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET Index with Past and future events + Attendees
        public IActionResult Index()
        {
            IEnumerable<Event> objList = _db.Events;

            var EventsInPastAndFutureViewModel = new EventsInPastAndFutureVM
            {
                EventsPast = _db.Events.Where(p => p.StartDate < DateTime.Now).OrderByDescending(p => p.StartDate),
                EventsFuture = _db.Events.Where(f => f.StartDate > DateTime.Now).OrderBy(p => p.StartDate),
                Attendees = _db.Attendees
            };
            return View(EventsInPastAndFutureViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
