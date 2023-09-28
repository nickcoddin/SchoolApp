namespace SchoolApp
{
    public class Program
    {
        public static void Main()
        {
            using (var context = new SchoolDbContext())
            {
                var teacherService = new TeacherService(context);
                var studentName = "Giorgi";

                var teachersTeachingGiorgi = teacherService.GetAllTeachersByStudent(studentName);

                Console.WriteLine($"Teachers who teach {studentName}:");
                foreach (var teacher in teachersTeachingGiorgi)
                {
                    Console.WriteLine($"{teacher.FirstName} {teacher.LastName}");
                }
            }
        }
    }
}