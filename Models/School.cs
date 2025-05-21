namespace LearningBackend.Models;

public class School
{
    public int SchoolId { get; set; } // Primary Key
    public string SchoolName { get; set; }
    public string SchoolCode { get; set; } // Optional: Unique ID or code
    public string SchoolAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PinCode { get; set; }

    public string ContactEmail { get; set; }
    public string ContactPhone { get; set; }

    public int StudentCount { get; set; }
    public int TeacherCount { get; set; }

    public string SchoolType { get; set; }
    public bool HasClass7 { get; set; }
    public bool HasClass8 { get; set; }
    public bool HasClass9 { get; set; }
    public bool HasClass10 { get; set; }
    public bool HasClass11 { get; set; }
    public bool HasClass12 { get; set; }
    

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}