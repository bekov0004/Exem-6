namespace Domain.Dtos;

public class TimeTableDto
{
    public int TTId { get; set; }
    public string Day { get; set; }
    public string Time { get; set; }
    public string Subject { get; set; }

    public TimeTableDto()
    {
        
    }

    public TimeTableDto(int ttId, string day, string time, string subject)
    {
        TTId = ttId;
        Day = day;
        Time = time;
        Subject = subject;
    }
}