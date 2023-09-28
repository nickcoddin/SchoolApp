namespace SchoolApp.Model
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<TeacherPupil> TeacherPupils { get; set; }
    }
}
