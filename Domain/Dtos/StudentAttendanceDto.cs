namespace Domain.Dtos;

public class StudentAttendanceDto
{
    public int UserId { get; set; } 
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int StudentId { get; set; }

    public StudentAttendanceDto()
    {
        
    }

    public StudentAttendanceDto(int userId, DateTime date, bool status, int studentId)
    {
        UserId = userId;
        Date = date;
        Status = status;
        StudentId = studentId;
    }
}