using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models;

public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "First Name is required")]
    [Display(Name = "First Name")]
    [StringLength(50)]
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Last Name is required")]
    [Display(Name = "Last Name")]
    [StringLength(50)]
    public string LastName { get; set; } = "";

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [Display(Name = "Email")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Date of Birth is required")]
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    [Display(Name = "Gender")]
    public string Gender { get; set; } = "";

    [Required(ErrorMessage = "Phone Number is required")]
    [Phone(ErrorMessage = "Invalid Phone Number")]
    [Display(Name = "Phone Number")]
    [StringLength(15)]
    public string PhoneNumber { get; set; } = "";

    [Display(Name = "Address")]
    [StringLength(200)]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Course is required")]
    [Display(Name = "Course")]
    public string Course { get; set; } = "";

    [Required(ErrorMessage = "Enrollment Date is required")]
    [Display(Name = "Enrollment Date")]
    [DataType(DataType.Date)]
    public DateTime EnrollmentDate { get; set; } = DateTime.Today;
}
