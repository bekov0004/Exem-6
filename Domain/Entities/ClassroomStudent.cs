using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
[Keyless]
public class ClassroomStudent
{
    public int StudentId { get; set; } 
    public int ClassroomId { get; set; } 

    public ClassroomStudent()
    {
        
    }

    public ClassroomStudent(int studentId, int classroomId)
    {
        StudentId = studentId;
        ClassroomId = classroomId;
    }
}