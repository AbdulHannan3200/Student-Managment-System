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
    public class EnrollmentsController(IEnrollmentService enrollmentService) : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService = enrollmentService;

        [HttpGet]
        public IEnumerable<Enrollment> GetEnrollments()
        {
            return _enrollmentService.GetAllEnrollments();
        }

        [HttpGet("{id}")]
        public ActionResult<EnrollmentDto> GetEnrollmentById(int id)
        {
            var enrollment = _enrollmentService.GetEnrollmentById(id);
            if (enrollment == null) return NotFound();
            return enrollment;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEnrollment(int id)
        {
            if (!_enrollmentService.DeleteEnrollment(id)) return NotFound();
            return NoContent();
        }
    }

}
