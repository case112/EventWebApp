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
        public IActionResult Create(int? id)
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

            return View();

        }

        //POST Attendee Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Attendee obj, int? id)
        {

            if (ModelState.IsValid)
            {
                _db.Attendees.Add(obj);
                _db.SaveChanges();
                return Redirect("~/");
            }

            ViewData["EventIdFromUrl"] = id;

            return View(obj);

        }
    }
}
