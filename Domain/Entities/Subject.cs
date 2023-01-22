using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
 
public class Subject
{
    [Key]
    public int SubjectId { get; set; } 
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Description { get; set; }
    public List<Result> Results { get; set; }

    public Subject()
    {
        
    }

    public Subject(int subjectId, string name, int grade, string description)
    {
        SubjectId = subjectId;
        Name = name;
        Grade = grade;
        Description = description;
    }
}