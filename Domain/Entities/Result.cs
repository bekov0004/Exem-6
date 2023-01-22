using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
 
public class Result
{
    [Key]
    public int ExamId { get; set; }
    public Exam Exam { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public int Marks { get; set; }

    public Result()
    {
        
    }

    public Result(int exemId, int studentId, int subjectId, int marks)
    {
        ExamId = exemId;
        StudentId = studentId;
        SubjectId = subjectId;
        Marks = marks;
    }
}