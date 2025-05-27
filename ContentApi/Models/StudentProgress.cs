using System.ComponentModel.DataAnnotations;

namespace LearningBackend.Models
{
    public class StudentProgress
    {
        [Key]
        public required string Id { get; set; } // NoSQL document ID

        [Required]
        public int StudentId { get; set; } // Link to SQL Student

        [Required]
        public int SchoolId { get; set; } // Link to SQL School

        [Required]
        public List<SubjectProgress> SubjectProgress { get; set; } = new();

        public List<string> Achievements { get; set; } = new();

        public List<string> Trophies { get; set; } = new();

        public DateTime LastUpdate { get; set; } = DateTime.UtcNow;
    }
}

namespace LearningBackend.Models
{
    public class SubjectProgress
    {
        public required string SubjectName { get; set; }

        public List<ChapterProgress> Chapters { get; set; } = new();
    }
}

namespace LearningBackend.Models
{
    public class ChapterProgress
    {
        public required string ChapterName { get; set; }

        public double CompletionPercentage { get; set; } // 0.0 to 100.0

        public bool IsUnlocked { get; set; }

        public DateTime? CompletedAt { get; set; }
    }
}