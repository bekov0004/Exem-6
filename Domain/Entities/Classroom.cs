using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
[Keyless]
public class Classroom
{
    public int ClassroomId { get; set; }
    public string Section { get; set; }
    public int Grade { get; set; }
    public int TeacherId { get; set; } 
    public Classroom()
    {
        
    }

    public Classroom(int classroomId, string section, int grade, int teacherId)
    {
        ClassroomId = classroomId;
        Section = section;
        Grade = grade;
        TeacherId = teacherId;
    }
}