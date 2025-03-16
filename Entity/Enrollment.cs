
namespace StudentManagmentSystem.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using StudentManagmentSystem.Entity;

    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public required Student Student { get; set; }

        [Required]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public required Course Course { get; set; }

        [Required]
        public DateTime EnrollmentDate { get; set; }
    }
}