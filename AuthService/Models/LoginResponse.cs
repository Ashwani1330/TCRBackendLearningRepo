namespace AuthService.Models;

public class LoginResponse
{
    public bool Success { get; set; }
    public required string Message { get; set; }
}