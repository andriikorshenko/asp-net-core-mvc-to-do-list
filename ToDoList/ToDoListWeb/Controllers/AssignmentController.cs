﻿using Microsoft.AspNetCore.Mvc;
using ToDoListWeb.Data;
using ToDoListWeb.Models;

namespace ToDoListWeb.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AssignmentController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Assignment> objAssignmentList = _db.Assignments;
            return View(objAssignmentList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Assignment obj)
        {
            _db.Assignments.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
