namespace StudentManagmentSystem.Service.Interface
{
    using System.Collections.Generic;
    using StudentManagmentSystem.Entity;

    public interface ICourseService
    {
        IEnumerable<Course>  GetAllCourses();
        Course GetCourseById(int id);
        bool DeleteCourse(int id);
    }

}
