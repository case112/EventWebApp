﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventWebApp.Data;
using EventWebApp.Models;
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

        // GET create
        public IActionResult Create()
        {
            return View();
        }

        //POST Create
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
    }
}
