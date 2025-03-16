using Microsoft.AspNetCore.Mvc;

namespace StudentManagmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StudentManagmentSystem.Entity;
    using StudentManagmentSystem.Service.Interface;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(ICourseService courseService) : ControllerBase
    {
        private readonly ICourseService _courseService = courseService;

     

        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return _courseService.GetAllCourses();
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetCourse(int id)
        {
            var course = _courseService.GetCourseById(id);
            if (course == null) return NotFound();
            return course;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            if (!_courseService.DeleteCourse(id)) return NotFound();
            return NoContent();
        }
    }

}
