/*using LearningBackend.DeviceMonitoringService.Models;
using Microsoft.EntityFrameworkCore;
using LearningBackend.Models;
using LearningBackend.school_admin_api.Models;
using LearningBackend.SchoolAdminApi.Models;

namespace LearningBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<Device> Devices { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<School> Schools { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudentProgress> Sessions { get; set; } = null!;
    }
}*/