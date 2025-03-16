using Microsoft.AspNetCore.Mvc;

namespace StudentManagmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StudentManagmentSystem.DTOs;
    using StudentManagmentSystem.Entity;
    using StudentManagmentSystem.Service.Interface;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _studentService.GetAllStudents();
        }

        [HttpGet("id/{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null) return NotFound();
            return student;
        }

        [HttpGet("name/{name}")]
        public ActionResult<Student> GetStudentinfo(string name)
        {
            var student = _studentService.GetStudentByFirstName(name);
            if (student == null) return NotFound();
            return student;
        }


        [HttpDelete("id/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (!_studentService.DeleteStudent(id)) return NotFound();
            return NoContent();
        }
    }

}
