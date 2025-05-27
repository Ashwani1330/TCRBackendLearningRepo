using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningBackend.SchoolAdminApi.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; } // Primary Key

        [Required]
        [MaxLength(100)]
        public required string SchoolName { get; set; }

        [MaxLength(20)]
        public required string SchoolCode { get; set; } // Optional: Unique ID or code

        [MaxLength(200)]
        public required string SchoolAddress { get; set; }

        [MaxLength(50)]
        public required string City { get; set; }

        [MaxLength(50)]
        public required string State { get; set; }

        [MaxLength(10)]
        public required string PinCode { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public required string ContactEmail { get; set; }

        [Phone]
        [MaxLength(20)]
        public required string ContactPhone { get; set; }

        public int StudentCount { get; set; }
        public int TeacherCount { get; set; }

        [MaxLength(50)]
        public required string SchoolType { get; set; }

        [Flags]
        public enum ClassesOffered
        {
            None = 0,
            Class7 = 1 << 0,
            Class8 = 1 << 1,
            Class9 = 1 << 2,
            Class10 = 1 << 3,
            Class11 = 1 << 4,
            Class12 = 1 << 5
        }

        [Column("ClassesOffered")]
        public ClassesOffered OfferedClasses { get; set; } = ClassesOffered.None;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}