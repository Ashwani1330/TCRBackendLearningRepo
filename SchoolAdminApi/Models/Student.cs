using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningBackend.SchoolAdminApi.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required, MaxLength(50)]
    public required string FirstName { get; set; }

    [Required, MaxLength(50)]
    public required string LastName { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public Gender Gender { get; set; }

    [EmailAddress, MaxLength(100)]
    public required string ParentEmail { get; set; }

    [Phone, MaxLength(20)]
    public required string ParentPhoneNumber { get; set; }

    [MaxLength(200)]
    public required string Address { get; set; }

    [Required, MaxLength(10)]
    public required string Standard { get; set; }

    [MaxLength(5)]
    public string? ClassName { get; set; }

    public int RollNumber { get; set; }

    [ForeignKey(nameof(School))]
    public int SchoolId { get; set; }

    public School? School { get; set; }

    public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
}

public enum Gender
{
    Male,
    Female,
    Other
}