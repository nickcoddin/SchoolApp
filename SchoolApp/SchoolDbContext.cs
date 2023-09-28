using Microsoft.EntityFrameworkCore;
using SchoolApp.Model;


namespace SchoolApp
{
    public class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database = newSchoolDB; Integrated Security = true; TrustServerCertificate=true;");
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<TeacherPupil> TeacherPupils { get; set; }

    }
}

