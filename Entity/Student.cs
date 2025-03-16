namespace StudentManagmentSystem.Entity
{
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Address { get; set; }
    }

}
