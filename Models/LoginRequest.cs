namespace LearningBackend.Models;

public class LoginRequest
{
    //User Input
    public string ClassName { get; set; }   
    public string RollNo { get; set; }
    public DateTime DOB { get; set; }
    
    //App gen Input
    public string Standard { get; set; } 
    public string DeviceId { get; set; }

}


