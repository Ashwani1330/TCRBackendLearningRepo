namespace LearningBackend.Models;

public class Student
{
    public int StudentId { get; set; } // Primary key

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; } // Or consider using enum

    public string ParentEmail { get; set; }
    public string ParentPhoneNumber { get; set; }

    public string Address { get; set; }

    public string Standard { get; set; } // Example: 7, 8, 9, etc.
    public string ClassName { get; set; } // Optional: A, B, etc.
    public int RollNumber { get; set; }

    public int SchoolId { get; set; } // Foreign Key to School
    public School School { get; set; } // Navigation Property

    public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
}