/*using System.Diagnostics;
using LearningBackend.Models;
using LearningBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace LearningBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }
        

        [HttpPost]
        public async Task<ActionResult<LoginResponse>> PostLogin([FromBody] LoginRequest request)
        {
            // TODO 1: Find the school ID based on the Device that is being logged in
            var device = await _context.Devices.FirstOrDefaultAsync(d => d.DeviceId == request.DeviceId);
            if (device == null)
            {
                return Ok(new LoginResponse
                {
                    Success = false,
                    Message = "Device not found"
                });
            }
            int schoolId = device.SchoolId;
            
            // TODO 2: Using the school ID, find a matching session
            var currentTime = DateTime.UtcNow;
            var session = await _context.Sessions.FirstOrDefaultAsync(s => 
                s.SchoolId == schoolId && 
                s.Standard == request.Standard && 
                s.ClassName == request.ClassName && 
                s.StartTime <= currentTime && 
                s.EndTime >= currentTime);

            if (session == null)
            {
                return Ok(new LoginResponse
                {
                    Success = false,
                    Message = "No active session found"
                });
            }
            else
            {
                // TODO 3: Find the student that matches the Roll no, class and DOB
                var student = await _context.Students.FirstOrDefaultAsync(s => 
                    s.SchoolId == schoolId &&
                    s.RollNumber.ToString() == request.RollNo &&
                    s.Standard.ToString() == request.Standard &&
                    s.ClassName == request.ClassName &&
                    s.DateOfBirth == request.DateOfBirth);

                if (student == null)
                {
                    return Ok(new LoginResponse
                    {
                        Success = false,
                        Message = "Student not found or credentials incorrect"
                    });
                }
        
                // If student found, return success
                return Ok(new LoginResponse
                {
                    Success = true,
                    Message = "Login successful"
                    //I want to call some Function !
                    
                }); 
            }
        }
    }
}*/