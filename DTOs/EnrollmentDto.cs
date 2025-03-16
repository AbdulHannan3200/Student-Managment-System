namespace StudentManagmentSystem.DTOs
{
    public class EnrollmentDto
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public string ? StudentName { get; set; }
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }

}
