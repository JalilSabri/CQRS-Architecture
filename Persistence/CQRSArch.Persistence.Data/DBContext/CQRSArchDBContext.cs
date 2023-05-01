using Microsoft.EntityFrameworkCore;

namespace CQRSArch.Persistence.Data.DBContext
{
    public class CQRSArchDBContext : DbContext
    {
        public CQRSArchDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentFluentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseFluentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseStudentFluentConfiguration());
        }
    }
}