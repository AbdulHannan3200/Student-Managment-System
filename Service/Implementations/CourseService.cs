namespace StudentManagmentSystem.Service.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using StudentManagmentSystem.Data;
    using StudentManagmentSystem.Entity;
    using StudentManagmentSystem.Service.Interface;

    public class CourseService(MyAppDbContext context) : ICourseService
    {
        private readonly MyAppDbContext _context = context;

        public IEnumerable<Course>  GetAllCourses()
        {
            return [.. _context.Courses];
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.Find(id);
        }

        public bool DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null) return false;

            _context.Courses.Remove(course);
            _context.SaveChanges();
            return true;
        }
    }

}
