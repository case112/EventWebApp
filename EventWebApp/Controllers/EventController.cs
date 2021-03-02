using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using EventWebApp.Data;
using EventWebApp.Models;
using EventWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace EventWebApp.Controllers
{
    public class EventController : Controller
    {

        private readonly ApplicationDbContext _db;

        public EventController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET Event Create
        public IActionResult Create()
        {
            return View();
        }

        //POST Event Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Event obj)
        {

            if (ModelState.IsValid)
            {
                _db.Events.Add(obj);
                _db.SaveChanges();
                return Redirect("~/");
            }
            return View(obj);

        }

        // GET Event Details
        public IActionResult Details(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Events.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            var EventAttendeeViewModel = new EventVM
            {

                Events = _db.Events.Where(e => e.Id == id),
                Attendees = _db.Attendees.Where(a => a.EventId == id)

            };


            return View(EventAttendeeViewModel);

        }

        //POST Event Delete
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var obj = _db.Events.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Events.Remove(obj);
            _db.SaveChanges();
            return Redirect("~/");
        }

    }
}
