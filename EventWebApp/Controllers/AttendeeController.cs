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

        //POST Attendee Delete
        [HttpPost]
        public IActionResult Delete(int? id, string returnUrl)
        {
            var obj = _db.Attendees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Attendees.Remove(obj);
            _db.SaveChanges();


            return Redirect(Request.Headers["Referer"].ToString());
        }


        // GET Attendee Update
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Attendees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);

        }


        // POST Attendee Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Attendee obj)
        {
            if (ModelState.IsValid)
            {
                _db.Attendees.Update(obj);
                _db.SaveChanges();
                return Redirect(Request.Headers["Referer"].ToString());
            }

            return Redirect("~/");

        }



    }
}
