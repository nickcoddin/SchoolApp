using SchoolApp.Model;
using SchoolApp;
using System.Linq;

public class TeacherService
{
    private readonly SchoolDbContext _context;

    public TeacherService(SchoolDbContext context)
    {
        _context = context;
    }

    public Teacher[] GetAllTeachersByStudent(string studentName)
    {
        return _context.Teachers
            .Where(teacher =>
                teacher.TeacherPupils
                    .Any(tp => tp.Pupil.FirstName == studentName))
            .ToArray();
    }
}