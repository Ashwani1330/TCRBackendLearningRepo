using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearningBackend.SchoolAdminApi.Models;

namespace LearningBackend.school_admin_api.Models;

public class Teacher
{
   
    [Key]
    public int TeacherId { get; set; } // Primary Key
    
    [Required, MaxLength(100)]
    public required string FullName { get; set; }
    
    [Required, EmailAddress, MaxLength(100)]
    public required string Email { get; set; }
    
    [Required, Phone, MaxLength(100)]
    public required string PhoneNumber { get; set; }
    
    [Required, MaxLength(50)]
    public required string Subject { get; set; }
    
    public bool IsClassTeacher { get; set; }

    [ForeignKey(nameof(School))]
    public int SchoolId { get; set; }
    
    public School? School { get; set; }
}