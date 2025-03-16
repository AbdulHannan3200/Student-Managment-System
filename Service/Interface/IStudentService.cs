namespace StudentManagmentSystem.Service.Interface
{
    using System.Collections.Generic;
    using StudentManagmentSystem.Entity;

    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        bool DeleteStudent(int id);
    }

}
