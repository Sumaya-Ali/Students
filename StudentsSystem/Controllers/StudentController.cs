using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    }
}
