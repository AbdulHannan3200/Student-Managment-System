namespace StudentManagmentSystem.Service.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using StudentManagmentSystem.Data;
    using StudentManagmentSystem.DTOs;
    using StudentManagmentSystem.Entity;
    using StudentManagmentSystem.Service.Interface;

    public class EnrollmentService(MyAppDbContext context) : IEnrollmentService
    {
        private readonly MyAppDbContext _context = context;

        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return [.. _context.Enrollments];
        }

        public EnrollmentDto? GetEnrollmentById(int enrollmentId)
        {
            var enrollmentDetails = _context.Enrollments
                .Where(e => e.Id == enrollmentId)
                .Select(e => new EnrollmentDto
                {
                    EnrollmentId = e.Id,
                    StudentId = e.StudentId,
                    StudentName = e.Student.FirstName + " " + e.Student.LastName,
                    CourseId = e.CourseId,
                    CourseName = e.Course.Name,
                    EnrollmentDate = e.EnrollmentDate
                })
                .FirstOrDefault(); // Fetch only one record

            return enrollmentDetails;
        }


        public bool DeleteEnrollment(int id)
        {
            var enrollment = _context.Enrollments.Find(id);
            if (enrollment == null) return false;

            _context.Enrollments.Remove(enrollment);
            _context.SaveChanges();
            return true;
        }
    }

}
