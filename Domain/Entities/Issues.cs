using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
[Keyless]
public class Issues
{
    public int IssueId { get; set; } 
    public string Type { get; set; }
    public string Details { get; set; }
    public bool IsResolved { get; set; }

    public Issues()
    {
        
    }

    public Issues(int issueId, string type, string details, bool isResolved)
    {
        IssueId = issueId;
        Type = type;
        Details = details;
        IsResolved = isResolved;
    }
}