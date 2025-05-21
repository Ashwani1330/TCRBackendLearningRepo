using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningBackend.Models
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string ClassName { get; set; }  
        [Required]
        public string Standard { get; set; }
        
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign key to Teacher
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        // Foreign key to School
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}