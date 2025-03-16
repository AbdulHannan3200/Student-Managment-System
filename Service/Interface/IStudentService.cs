namespace StudentManagmentSystem.Service.Interface
{
    using System.Collections.Generic;
    using StudentManagmentSystem.DTOs;
    using StudentManagmentSystem.Entity;

    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        Student GetStudentByFirstName(string name);
        bool DeleteStudent(int id);
    }

}
