namespace Domain.Dtos;

public class ClassroomDto
{
    public int ClassroomId { get; set; }
    public string Section { get; set; }
    public int Grade { get; set; }
    public int Teacher_Id { get; set; }

    public ClassroomDto()
    {
        
    }

    public ClassroomDto(int classroomId, string section, int grade, int teacherId)
    {
        ClassroomId = classroomId;
        Section = section;
        Grade = grade;
        Teacher_Id = teacherId;
    }
}