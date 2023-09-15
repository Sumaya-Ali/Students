using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using OL=ObjectLayer;
namespace StudentsSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult GetAllStudents()
        {
            return View(_studentService.GetAllStudents());
        }

        public IActionResult CreateNewStudent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNewStudent(OL::Student student)
        {
            _studentService.CreateNewStudent(student);
            return RedirectToAction("GetAllStudents");
        }

        public IActionResult EditStudent(int id)
        {
            var student = _studentService.EditStudent(id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditStudent(OL::Student student)
        {
            _studentService.EditStudent(student);
            return RedirectToAction("GetAllStudents");
        }

    }
}
