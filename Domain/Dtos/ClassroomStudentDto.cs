namespace Domain.Dtos;

public class ClassroomStudentDto
{
    public int StudentId { get; set; }
    public int ClassroomId { get; set; }

    public ClassroomStudentDto()
    {
        
    }

    public ClassroomStudentDto(int studentId, int classroomId)
    {
        StudentId = studentId;
        ClassroomId = classroomId;
    }
}