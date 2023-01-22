using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
 
public class StudentAttendance
{
    [Key]
    public int UserId { get; set; }
 
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    
    public StudentAttendance()
    {
        
    }

    public StudentAttendance(int userId, DateTime date, bool status, int studentId)
    {
        UserId = userId;
        Date = date;
        Status = status;
        StudentId = studentId; 
    }
}