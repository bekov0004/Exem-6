namespace Domain.Dtos;

public class SubjectDto
{
    public int SubjectId { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Description { get; set; }

    public SubjectDto()
    {
        
    }

    public SubjectDto(int subjectId, string name, int grade, string description)
    {
        SubjectId = subjectId;
        Name = name;
        Grade = grade;
        Description = description;
    }
}