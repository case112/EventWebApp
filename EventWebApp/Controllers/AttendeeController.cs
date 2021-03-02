using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventWebApp.Data;
using EventWebApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace EventWebApp.Controllers
{

    public class AttendeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AttendeeController(ApplicationDbContext db)
        {
            _db = db;
        }


        // GET Attendee Create
        [HttpGet]
        public IActionResult Create(int? eventId)
        {
            if (eventId == null || eventId == 0)
            {
                return NotFound();
            }

            var id = eventId;
            var obj = _db.Events.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            ViewData["EventId"] = eventId;

            return View();

        }

        //POST Attendee Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int? eventId, Attendee obj)
        {


            if (ModelState.IsValid)
            {
                _db.Attendees.Add(obj);
                _db.SaveChanges();
                return Redirect("~/");
            }

            ViewData["EventId"] = eventId;

            return View(obj);

        }
    }
}
