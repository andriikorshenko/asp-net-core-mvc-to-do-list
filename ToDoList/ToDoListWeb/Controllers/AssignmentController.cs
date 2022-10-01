using Microsoft.AspNetCore.Mvc;
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

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Assignment> objAssignmentList = _db.Assignments;
            return View(objAssignmentList);
        }

        public IActionResult Create()
        {
            IEnumerable<Assignment> objAssignmentList = _db.Assignments;
            return View(objAssignmentList);
        }
    }
}
