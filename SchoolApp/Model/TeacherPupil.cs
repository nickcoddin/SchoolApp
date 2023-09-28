
using SchoolApp.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

public class TeacherPupil
{
    public int TeacherPupilID { get; set; }


    [ForeignKey("TeacherID")]
    public int TeacherID { get; set; }

    [ForeignKey("PupilID")]
    public int PupilID { get; set; }


    public virtual Teacher Teacher { get; set; }
    public virtual Pupil Pupil { get; set; }
}

