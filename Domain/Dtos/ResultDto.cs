namespace Domain.Dtos;

public class ResultDto
{
    public int ExemId { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public int Marks { get; set; }

    public ResultDto()
    {
        
    }

    public ResultDto(int exemId, int studentId, int subjectId, int marks)
    {
        ExemId = exemId;
        StudentId = studentId;
        SubjectId = subjectId;
        Marks = marks;
    }
}