using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Student
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)
        { }
      
        public DbSet<Students> Student {  get; set; }
        
    }
}

