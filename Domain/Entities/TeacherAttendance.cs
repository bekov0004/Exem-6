using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
 
public class TeacherAttendance
{
    [Key]
    public int UserId { get; set; }
 
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    
    public TeacherAttendance()
    {
        
    }

    public TeacherAttendance(int userId, DateTime date, bool status, int teacherId)
    {
        UserId = userId;
        Date = date;
        Status = status;
        TeacherId = teacherId; 
    }
}