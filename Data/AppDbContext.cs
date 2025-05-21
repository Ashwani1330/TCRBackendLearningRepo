using Microsoft.EntityFrameworkCore;
using LearningBackend.Models;

namespace LearningBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<Device> Devices { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<School> Schools { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Session> Sessions { get; set; } = null!;
    }
}