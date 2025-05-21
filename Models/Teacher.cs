namespace LearningBackend.Models;

public class Teacher
{
   
    public int TeacherId { get; set; } // Primary Key
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Subject { get; set; }
    public bool IsClassTeacher { get; set; }

    public int SchoolId { get; set; }
    public School School { get; set; }
    
}