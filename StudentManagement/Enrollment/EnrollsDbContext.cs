using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Enrollment
{
    public class EnrollsDbContext : DbContext 
    {
        public EnrollsDbContext(DbContextOptions<EnrollsDbContext> actions) 
            : base(actions) { }


        public DbSet<Enrollments> Enrollment {  get; set; }

    }
}
