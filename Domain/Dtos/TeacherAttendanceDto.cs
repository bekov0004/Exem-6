namespace Domain.Dtos;

public class TeacherAttendanceDto
{
    public int UserId { get; set; } 
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int TeacherId { get; set; }

    public TeacherAttendanceDto()
    {
        
    }

    public TeacherAttendanceDto(int userId, DateTime date, bool status, int teacherId)
    {
        UserId = userId;
        Date = date;
        Status = status;
        TeacherId = teacherId;
    }
}