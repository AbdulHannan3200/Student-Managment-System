namespace StudentManagmentSystem.Entity { 
using System.ComponentModel.DataAnnotations;

public class Course
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Description { get; set; }

    [Required]
    public int Credits { get; set; }
}

}