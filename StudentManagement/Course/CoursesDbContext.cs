using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Course
{
    public class CoursesDbContext : DbContext 
    {
        public CoursesDbContext(DbContextOptions<CoursesDbContext> choices) : base(choices) { }

        public DbSet<Courses> Courses { get; set; }

    }
}
