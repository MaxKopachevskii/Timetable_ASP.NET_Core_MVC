using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET_Core_Timetable.Models;

namespace ASP.NET_Core_Timetable.Controllers
{
    public class HomeController : Controller
    {
        TimetableDbContext db;
        public HomeController(TimetableDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Timetable()
        {
            var timetable = db.Timetables.ToList();
            return View(timetable);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Timetable timetable)
        {
            db.Timetables.Add(timetable);
            db.SaveChanges();
            return RedirectToAction("Timetable");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var timetable = db.Timetables.Find(id);
            return View(timetable);
        }

        [HttpPost]
        public IActionResult Edit(Timetable timetable)
        {
            db.Timetables.Update(timetable);
            db.SaveChanges();
            return RedirectToAction("Timetable");
        }

        public IActionResult Delete(int id)
        {
            var timetable = db.Timetables.Find(id);
            if (timetable != null)
            {
                db.Timetables.Remove(timetable);
                db.SaveChanges();
                return RedirectToAction("Timetable");
            }
            return NotFound();
        }

        public IActionResult Details(int id)
        {
            var timetable = db.Timetables.Find(id);
            return View(timetable);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
