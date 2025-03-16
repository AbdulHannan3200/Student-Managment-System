namespace StudentManagmentSystem.Service.Interface
{
    using System.Collections.Generic;
    using StudentManagmentSystem.DTOs;
    using StudentManagmentSystem.Entity;

    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetAllEnrollments();
        EnrollmentDto ? GetEnrollmentById(int id);
        bool DeleteEnrollment(int id);
    }

}
