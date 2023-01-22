namespace Domain.Dtos;

public class ExamDto
{
    public int ExemId { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public int Type { get; set; }

    public ExamDto()
    {
        
    }

    public ExamDto(int exemId, DateTime date, string name, int type)
    {
        ExemId = exemId;
        Date = date;
        Name = name;
        Type = type;
    }
}