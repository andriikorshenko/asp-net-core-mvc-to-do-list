using Microsoft.AspNetCore.Mvc;
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
        [Route("")]
        public IActionResult Index()
        {
            IEnumerable<Assignment> objAssignmentList = _db.Assignments.OrderByDescending(x => x.CreatedAt);
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
            if (ModelState.IsValid)
            {
                _db.Assignments.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var findById = _db.Assignments.Find(id);

            if (findById == null)
            {
                return NotFound();
            }

            return View(findById);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Assignment obj)
        {
            if (ModelState.IsValid)
            {
                _db.Assignments.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var findById = _db.Assignments.Find(id);

            if (findById == null)
            {
                return NotFound();
            }

            return View(findById);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Assignments.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Assignments.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
