using Microsoft.EntityFrameworkCore;

namespace Atividade_01.Data
{
    public class CompanyContext : DbContext
    {

        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<StudentCourses> StudentCourses { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().ToTable("Student");
        //    modelBuilder.Entity<Course>().ToTable("Course");
        //    modelBuilder.Entity<StudentCourses>().ToTable("StudentCourse");
        //}
    }
}
