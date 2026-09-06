using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Faculty is required")]
    [StringLength(50, ErrorMessage = "Faculty cannot exceed 50 characters")]
    public string Faculty { get; set; } = string.Empty;

    [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string? Email { get; set; }

    public DateTime EnrollmentDate { get; set; } = DateTime.Now;
}