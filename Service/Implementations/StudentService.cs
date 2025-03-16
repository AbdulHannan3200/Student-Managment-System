namespace StudentManagmentSystem.Service.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using StudentManagmentSystem.Data;
    using StudentManagmentSystem.Entity;
    using StudentManagmentSystem.Service.Interface;

    public class StudentService : IStudentService
    {
        private readonly MyAppDbContext _context;

        public StudentService(MyAppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public bool DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return false;

            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }
    }

}
