using StudentManagmentSystem.Entity;

namespace StudentManagmentSystem.Data
{
    using Microsoft.EntityFrameworkCore;

    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }

}
