
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LearningBackend.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; } // primary key
        [Required]
        public string DeviceId { get; set; }
        [Required]
        public string HardwareId { get; set; }
        
        // Foreign key to School
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}