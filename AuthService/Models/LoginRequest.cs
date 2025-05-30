using System.ComponentModel.DataAnnotations;

namespace AuthService.Models;

public class LoginRequest
{
    // User Input
    [Required, MaxLength(5)]
    public required string ClassName { get; set; }

    [Required, MaxLength(10)]
    public required string RollNo { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    // App gen Input
    [Required, MaxLength(10)]
    public required string Standard { get; set; }

    [Required, MaxLength(100)]
    public required string DeviceId { get; set; }
}