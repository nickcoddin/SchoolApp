﻿public class Pupil
{
    public int PupilID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Class { get; set; }
    public virtual ICollection<TeacherPupil> TeacherPupils { get; set; }
}
