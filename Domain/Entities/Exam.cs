using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
 
public class Exam
{
   [Key]
    public int ExemId { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public int Type { get; set; }
    public Result Result { get; set; }
    public Exam()
    {
        
    }

    public Exam(int exemId, DateTime date, string name, int type)
    {
        ExemId = exemId;
        Date = date;
        Name = name;
        Type = type;
    }
}