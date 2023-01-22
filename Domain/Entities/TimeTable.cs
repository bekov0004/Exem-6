using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
[Keyless]
public class TimeTable
{
    public int TTId { get; set; } 
    public string Day { get; set; }
    public string Time { get; set; }
    public string Subject { get; set; }

    public TimeTable()
    {
        
    }

    public TimeTable(int ttId, string day, string time, string subject)
    {
        TTId = ttId;
        Day = day;
        Time = time;
        Subject = subject;
    }
}